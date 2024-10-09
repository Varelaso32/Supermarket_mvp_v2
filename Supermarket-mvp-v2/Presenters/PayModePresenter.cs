using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;
using Supermarketmvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeletEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }//Fin de la clase

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();

        }//Fin de la clase

        private void SavePayMode(object sender, EventArgs e)
        {
            var payMode = new PayModeModel();

            // Validar que el ID sea un número válido
            if (!int.TryParse(view.PayModeId, out int id))
            {
                view.Message = "El ID del modo de pago debe ser un número válido.";
                view.IsSuccessful = false;
                return;
            }

            payMode.Id = id;
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);

                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "Método de pago editado correctamente";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "Método de pago añadido correctamente";
                }

                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }


        private void DeleteSelectedPayMode(object sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)payModeBindingSource.Current;

                repository.Delete(payMode.Id);

                view.IsSuccessful = true;
                view.Message = "Método de pago eliminado correctamente";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar el método de pago";
            }

        }//Fin de la clase

        private void LoadSelectPayModeToEdit(object sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            view.IsEdit = true;


        }//Fin de la clase

        private void AddNewPayMode(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }//Fin de la clase

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;

        }//Fin de la clase


        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";

        }//Fin de la clase

    }//Fin de la clase

}
