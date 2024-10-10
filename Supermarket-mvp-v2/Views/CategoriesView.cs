using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supermarket_mvp_v2.Views
{
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        private static CategoriesView instance;
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoriesDetail);
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
                ClearSearchBox();
                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Añadir nueva categoría";
            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                ClearSearchBox();
                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Editar categoría";
            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                    tabControl1.TabPages.Add(tabPageCategoriesList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                tabControl1.TabPages.Add(tabPageCategoriesList);
            };

            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar la categoría seleccionada?",
                    "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                    ClearSearchBox();
                }
            };

            TxtSearch.Click += delegate
            {
                TxtSearch.Clear();
            };
        }

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
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
        }

        public string CategoryId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        public string CategoryName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        public string CategoryDescription
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }

        public string CategorySearchValue
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

        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            DgCustomers.DataSource = categoryList;
        }

        private void SetPlaceholders()
        {
            TxtPayModeId.Text = "0";
            TxtPayModeName.Text = "Ingrese el nombre de la categoría";
            TxtPayModeObservation.Text = "Ingrese la descripción de la categoría";

            TxtPayModeId.Enter += TextBox_Enter;
            TxtPayModeName.Enter += TextBox_Enter;
            TxtPayModeObservation.Enter += TextBox_Enter;

            TxtPayModeId.Leave += TextBox_Leave;
            TxtPayModeName.Leave += TextBox_Leave;
            TxtPayModeObservation.Leave += TextBox_Leave;
        }

        private void ClearSearchBox()
        {
            TxtSearch.Text = "Ingrese el término de búsqueda";
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
                if (textBox == TxtPayModeName) textBox.Text = "Ingrese el nombre de la categoría";
                else if (textBox == TxtPayModeObservation) textBox.Text = "Ingrese la descripción de la categoría";
            }
        }
    }
}
