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
        public event EventHandler LoadAllPayModesEvent;


        public PayModeView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };

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
            };//

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearSearchBox();

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Añadir nuevo método de pago";

                LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);

            };//

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                ClearSearchBox();

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Editar método de pago";

                LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);
            };//

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePayModeDetail);
                    tabControl1.TabPages.Add(tabPagePayModeList);
                    ClearSearchBox();
                }

                MessageBox.Show(Message);
            };//

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearSearchBox();
                tabControl1.TabPages.Remove(tabPagePayModeDetail);
                tabControl1.TabPages.Add(tabPagePayModeList);

            };//

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el método de pago seleccionado?",
                    "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeletEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                    ClearSearchBox();

                    LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);
                }
            };//

        }
        //Fin de la clase

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;

        }//Fin de la clase

        private static PayModeView instance;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
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

        private void ClearSearchBox()
        {
            TxtSearch.Text = string.Empty;
            TxtSearch.PlaceholderText = "Ingrese el término de búsqueda";

        }//Fin de la clase

        
    }//Fin de la clase

}
