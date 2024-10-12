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

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);
            LoadAllProductList();

            this.view.Show();

        }//Fin de clase

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;

        }//Fin de clase

        private void CancelAction(object sender, EventArgs e)
        {
            LoadAllProductList();

        }//Fin de clase

        private void SaveProduct(object sender, EventArgs e)
        {
            int productId = 0;
            if (!string.IsNullOrEmpty(view.ProductId))
            {
                productId = Convert.ToInt32(view.ProductId);
            }

            var product = new ProductsModels
            {
                Id = productId,
                Name = view.ProductName,
                Price = decimal.TryParse(view.ProductPrice, out decimal price) ? price : 0,
                Stock = int.TryParse(view.ProductStock, out int stock) ? stock : 0,
                CategoryId = int.TryParse(view.ProductCategoryId, out int categoryId) ? categoryId : 0
            };

            try
            {
                new Common.ModelDataValidation().Validate(product);

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Producto editado correctamente.";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Producto añadido correctamente.";
                }

                view.IsSuccessful = true;
                LoadAllProductList();
                ClearSearchField();
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
                ClearSearchField();    
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar el producto";
            }

        }//Fin de clase

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductsModels)productBindingSource.Current;

            if (product != null)
            {
                view.ProductId = product.Id.ToString();
                view.ProductName = product.Name;
                view.ProductPrice = product.Price.ToString();
                view.ProductStock = product.Stock.ToString();
                view.ProductCategoryId = product.CategoryId.ToString();
                view.IsEdit = true;
            }
            else
            {
                view.Message = "No se ha seleccionado ningún producto para editar.";
            }

        }//Fin de clase

        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
            LoadAllProductList();  
            ClearSearchField();

        }//Fin de clase

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

        }//Fin de clase



        private void ClearSearchField()
        {
            view.SearchValue = "";

        }//Fin de clase
    }
}
