using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;

namespace Supermarket_mvp_v2.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoriesModel> categoryList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.categoryBindingSource = new BindingSource();

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBindingSource(categoryBindingSource);
            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
            LoadAllCategoryList();
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            var category = new CategoriesModel
            {
                Id = Convert.ToInt32(view.CategoryId),
                Name = view.CategoryName,
                Description = view.CategoryDescription
            };

            try
            {
                new Common.ModelDataValidation().Validate(category);

                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Categoría editada correctamente";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Categoría añadida correctamente";
                }

                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
                ClearSearchField();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            try
            {
                var category = (CategoriesModel)categoryBindingSource.Current;
                if (category == null)
                {
                    view.Message = "No se ha seleccionado ninguna categoría para eliminar.";
                    return;
                }

                repository.Delete(category.Id);
                view.IsSuccessful = true;
                view.Message = "Categoría eliminada correctamente"; 
                LoadAllCategoryList();
                ClearSearchField();
            }
            catch (InvalidOperationException ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar la categoría"; 
            }
        }


        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            var category = (CategoriesModel)categoryBindingSource.Current;

            if (category != null)
            {
                view.CategoryId = category.Id.ToString();
                view.CategoryName = category.Name;
                view.CategoryDescription = category.Description;
                view.IsEdit = true;
            }
            else
            {
                view.Message = "No se ha seleccionado ninguna categoría para editar.";
            }
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            view.IsEdit = false;
            LoadAllCategoryList();
            ClearSearchField();
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.CategorySearchValue);
            if (!emptyValue)
            {
                categoryList = repository.GetByValue(this.view.CategorySearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;
        }

        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryDescription = "";
        }

        private void ClearSearchField()
        {
            view.CategorySearchValue = "";
        }
    }
}
