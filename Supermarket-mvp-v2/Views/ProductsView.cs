using System;
using System.ComponentModel;
using System.Windows.Forms;
using Supermarket_mvp_v2.Models;

namespace Supermarket_mvp_v2.Views
{
    public partial class ProductsView : Form, IProductsView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductsDetail);

            SetPlaceholders();

            BtnClose.Click += delegate { this.Close(); };
        }

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

            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Añadir nuevo producto";

                // Mostrar los placeholders
                SetPlaceholders();
            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Editar producto";
            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductsDetail);
                    tabControl1.TabPages.Add(tabPageProductsList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsDetail);
                tabControl1.TabPages.Add(tabPageProductsList);
            };

            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el producto seleccionado?",
                    "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public string ProductId
        {
            get { return TxtProductsId.Text; }
            set { TxtProductsId.Text = value; }
        }

        public string ProductName
        {
            get { return TxtProductsName.Text; }
            set { TxtProductsName.Text = value; }
        }

        public string ProductPrice
        {
            get { return TxtProductsPrecio.Text; }
            set { TxtProductsPrecio.Text = value; }
        }

        public string ProductStock
        {
            get { return TxtProductsStock.Text; }
            set { TxtProductsStock.Text = value; }
        }

        public string ProductCategoryId
        {
            get { return TxtProductsCategoria.Text; }
            set { TxtProductsCategoria.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public void SetProductListBindingSource(BindingSource productList)
        {
            DgProducts.DataSource = productList;
        }

        private static ProductsView instance;

        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
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

        public void Show()
        {
            base.Show();
        }

        private void SetPlaceholders()
        {
            TxtProductsId.Text = "0";
            TxtProductsName.Text = "Ingrese el nombre del producto";
            TxtProductsPrecio.Text = "Ingrese el precio del producto";
            TxtProductsStock.Text = "Ingrese el stock del producto";
            TxtProductsCategoria.Text = "Ingrese el ID de la categoría";

            TxtProductsId.Enter += TextBox_Enter;
            TxtProductsId.Leave += TextBox_Leave;
            TxtProductsName.Enter += TextBox_Enter;
            TxtProductsName.Leave += TextBox_Leave;
            TxtProductsPrecio.Enter += TextBox_Enter;
            TxtProductsPrecio.Leave += TextBox_Leave;
            TxtProductsStock.Enter += TextBox_Enter;
            TxtProductsStock.Leave += TextBox_Leave;
            TxtProductsCategoria.Enter += TextBox_Enter;
            TxtProductsCategoria.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
            if (textBox.Text.Contains("Ingrese"))
            {
                textBox.Text = "";
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == TxtProductsName) textBox.Text = "Ingrese el nombre del producto";
                else if (textBox == TxtProductsPrecio) textBox.Text = "Ingrese el precio del producto";
                else if (textBox == TxtProductsStock) textBox.Text = "Ingrese el stock del producto";
                else if (textBox == TxtProductsCategoria) textBox.Text = "Ingrese el ID de la categoría";
            }
        }
    }
}
