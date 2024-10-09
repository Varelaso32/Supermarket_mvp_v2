using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;

namespace Supermarket_mvp_v2.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository; 
        private BindingSource productBindingSource;
        private IEnumerable<ProductsModels> productList;


        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.productBindingSource = new BindingSource();

            // Asociar eventos
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);
            LoadAllProductList();

            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var product = new ProductsModels
            {
                Id = Convert.ToInt32(view.ProductId),
                Name = view.ProductName,
                Price = Convert.ToDecimal(view.ProductPrice),
                Stock = Convert.ToInt32(view.ProductStock),
                CategoryId = Convert.ToInt32(view.ProductCategoryId)
            };

            try
            {
                new Common.ModelDataValidation().Validate(product);

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Producto editado correctamente";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Producto añadido correctamente";
                }

                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }


        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductsModels)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Producto eliminado correctamente";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar el producto";
            }
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductsModels)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.ProductCategoryId = product.CategoryId.ToString();

            view.IsEdit = true;
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields(); 
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                productList = repository.GetByCategory(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "";
            view.ProductStock = "";
            view.ProductCategoryId = "";
        }
    }
}
