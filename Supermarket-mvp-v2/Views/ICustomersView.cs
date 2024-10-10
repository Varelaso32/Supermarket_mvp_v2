using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Supermarket_mvp_v2.Views
{
    internal interface ICustomersView
    {
        string CustomersId { get; set; }
        string CustomersDocumentNumber { get; set; }
        string CustomersFirstName { get; set; }
        string CustomersLastName { get; set; }
        string CustomersAddress { get; set; }
        string CustomersBirthDate { get; set; }
        string CustomersPhoneNumber { get; set; }
        string CustomersEmail { get; set; }
        string CustomersSearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomerListBindingSource(BindingSource customerList);
        void Show();
    } // Fin de la interfaz
}
