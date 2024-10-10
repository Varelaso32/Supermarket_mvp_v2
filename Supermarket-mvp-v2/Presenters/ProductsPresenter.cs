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
            CleanViewFields();
            LoadAllProductList();

        }//Fin de clase

        private void SaveProduct(object sender, EventArgs e)
        {
            // Crear un nuevo objeto de producto
            var product = new ProductsModels();

            // Validar y convertir el ProductId
            if (!int.TryParse(view.ProductId, out int productId))
            {
                view.Message = "El ID del producto no es válido.";
                view.IsSuccessful = false;
                return;
            }
            product.Id = productId;

            // Validar y convertir el ProductName
            if (string.IsNullOrWhiteSpace(view.ProductName))
            {
                view.Message = "El nombre del producto no puede estar vacío.";
                view.IsSuccessful = false;
                return;
            }
            product.Name = view.ProductName;

            // Validar y convertir el ProductPrice
            if (!decimal.TryParse(view.ProductPrice, out decimal productPrice))
            {
                view.Message = "El precio del producto no es válido.";
                view.IsSuccessful = false;
                return;
            }
            product.Price = productPrice;

            // Validar y convertir el ProductStock
            if (!int.TryParse(view.ProductStock, out int productStock))
            {
                view.Message = "El stock del producto no es válido.";
                view.IsSuccessful = false;
                return;
            }
            product.Stock = productStock;

            // Validar y convertir el CategoryId
            if (!int.TryParse(view.ProductCategoryId, out int categoryId))
            {
                view.Message = "El ID de la Categoria no es válida.";
                view.IsSuccessful = false;
                return;
            }
            product.CategoryId = categoryId;

            try
            {
                new Common.ModelDataValidation().Validate(product); // Realiza la validación de los datos

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Producto editado correctamente."; // Mensaje exitoso al editar
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Producto añadido correctamente."; // Mensaje exitoso al agregar
                }

                view.IsSuccessful = true;
                LoadAllProductList(); // Cargar la lista actualizada de productos
            }
            catch (ArgumentException ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message; // Mensaje específico para el CategoryId no existente
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error: " + ex.Message; // Mensaje de error si ocurre una excepción
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

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "";
            view.ProductStock = "";
            view.ProductCategoryId = "";

        }//Fin de clase

        private void ClearSearchField()
        {
            view.SearchValue = "";

        }//Fin de clase
    }
}
