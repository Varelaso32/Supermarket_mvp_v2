using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp_v2.Views
{
    internal interface ICategoriesView
    {
        string CategoryId { get; set; }
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
        string CategorySearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCategoryListBindingSource(BindingSource categoryList);
        void Show();

    } // Fin de la interfaz
}
