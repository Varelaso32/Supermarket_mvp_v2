using System;
using System.Collections.Generic;
using System.ComponentModel;
using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;

namespace Supermarket_mvp_v2.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository; 
        private BindingSource customerBindingSource;
        private IEnumerable<CustomersModel> customerList; 

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.customerBindingSource = new BindingSource();

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBindingSource(customerBindingSource);
            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll(); 
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
            LoadAllCustomerList();
        }

        private void SaveCustomer(object sender, EventArgs e)
        {
            var customer = new CustomersModel
            {
                Id = Convert.ToInt32(view.CustomersId),
                DocumentNumber = view.CustomersDocumentNumber,
                FirstName = view.CustomersFirstName,
                LastName = view.CustomersLastName,
                Address = view.CustomersAddress,
                BirthDate = view.CustomersBirthDate,
                PhoneNumber = view.CustomersPhoneNumber,
                Email = view.CustomersEmail
            };

            try
            {
                new Common.ModelDataValidation().Validate(customer); 

                if (view.IsEdit)
                {
                    repository.Edit(customer); 
                    view.Message = "Cliente editado correctamente";
                }
                else
                {
                    repository.Add(customer); 
                    view.Message = "Cliente añadido correctamente";
                }

                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
                ClearSearchField();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCustomer(object sender, EventArgs e)
        {
            try
            {
                var customer = (CustomersModel)customerBindingSource.Current;
                repository.Delete(customer.Id); 
                view.IsSuccessful = true;
                view.Message = "Cliente eliminado correctamente";
                LoadAllCustomerList();
                ClearSearchField();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar el cliente";
            }
        }

        private void LoadSelectedCustomerToEdit(object sender, EventArgs e)
        {
            var customer = (CustomersModel)customerBindingSource.Current;

            if (customer != null)
            {
                view.CustomersId = customer.Id.ToString();
                view.CustomersDocumentNumber = customer.DocumentNumber;
                view.CustomersFirstName = customer.FirstName;
                view.CustomersLastName = customer.LastName;
                view.CustomersAddress = customer.Address;
                view.CustomersBirthDate = customer.BirthDate;
                view.CustomersPhoneNumber = customer.PhoneNumber;
                view.CustomersEmail = customer.Email;
                view.IsEdit = true;
            }
            else
            {
                view.Message = "No se ha seleccionado ningún cliente para editar.";
            }
        }

        private void AddNewCustomer(object sender, EventArgs e)
        {
            view.IsEdit = false;
            LoadAllCustomerList();
            ClearSearchField();
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.CustomersSearchValue);
            if (!emptyValue)
            {
                customerList = repository.GetByValue(this.view.CustomersSearchValue); 
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersDocumentNumber = "";
            view.CustomersFirstName = "";
            view.CustomersLastName = "";
            view.CustomersAddress = "";
            view.CustomersBirthDate = "";
            view.CustomersPhoneNumber = "";
            view.CustomersEmail = "";
        }

        private void ClearSearchField()
        {
            view.CustomersSearchValue = "";
        }
    }
}
