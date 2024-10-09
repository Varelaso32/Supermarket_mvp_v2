using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp_v2.Models;

namespace Supermarket_mvp_v2.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeletEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            //tabControl1.TabPages.Remove(tabPagePayModeDetail);

        }//Fin de la clase

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }//Fin de la clase

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;

        }//Fin de la clase

        private static PayModeView instance;

        public static PayModeView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;

        }//Fin de la clase

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }

        }//Fin de la clase

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }

        }//Fin de la clase

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }

        }//Fin de la clase

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }//Fin de la clase

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }

        }//Fin de la clase

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }

        }//Fin de la clase

        public string Message
        {
            get { return message; }
            set { message = value; }

        }//Fin de la clase

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

    }//Fin de la clase

}
