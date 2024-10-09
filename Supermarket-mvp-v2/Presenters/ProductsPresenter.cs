using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermarket_mvp_v2.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository; // Asegúrate de tener esta interfaz creada
        private BindingSource productBindingSource;
        private IEnumerable<ProductsModels> productList; // Asegúrate de tener esta clase de modelo creada

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Asociar eventos
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            // Configurar el BindingSource
            this.view.SetProductListBindingSource(productBindingSource);

            // Cargar todos los productos
            LoadAllProducts();

            // Mostrar la vista
            this.view.Show();
        }

        private void LoadAllProducts()
        {
            productList = repository.GetAll(); // Asegúrate de que este método esté definido en tu repositorio
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var product = new ProductModel
            {
                Id = Convert.ToInt32(view.ProductId),
                Name = view.ProductName,
                Price = Convert.ToInt32(view.ProductPrice), // Cambia a int como pediste
                Stock = Convert.ToInt32(view.ProductStock),
                CategoryId = view.ProductCategoryId
            };

            try
            {
                // Validar datos antes de guardar
                new Common.ModelDataValidation().Validate(product); // Asegúrate de que esto esté implementado
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
                LoadAllProducts();
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
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id); // Asegúrate de que esto esté implementado

                view.IsSuccessful = true;
                view.Message = "Producto eliminado correctamente";
                LoadAllProducts();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar el producto";
            }
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.ProductCategoryId = product.CategoryId;

            view.IsEdit = true;
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                productList = repository.GetByValue(view.SearchValue); // Asegúrate de que este método esté definido en tu repositorio
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
            view.ProductPrice = "0"; // Puedes ajustarlo según lo que necesites
            view.ProductStock = "0"; // Puedes ajustarlo según lo que necesites
            view.ProductCategoryId = "";
        }
    }
}
