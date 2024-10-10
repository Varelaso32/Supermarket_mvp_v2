using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supermarket_mvp_v2.Views
{
    public partial class CustomersView : Form, ICustomersView
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

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCustomersDetail);
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
                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Añadir nuevo cliente";
            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                ClearSearchBox();
                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Editar cliente";
            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCustomersDetail);
                    tabControl1.TabPages.Add(tabPageCustomersList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCustomersDetail);
                tabControl1.TabPages.Add(tabPageCustomersList);
            };

            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el cliente seleccionado?",
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

        public string CustomersId
        {
            get { return TxtCustomersId.Text; }
            set { TxtCustomersId.Text = value; }
        }

        public string CustomersDocumentNumber
        {
            get { return TxtCustomersDocumento.Text; }
            set { TxtCustomersDocumento.Text = value; }
        }

        public string CustomersFirstName
        {
            get { return TxtCustomersName.Text; }
            set { TxtCustomersName.Text = value; }
        }

        public string CustomersLastName
        {
            get { return TxtCustomersApellido.Text; }
            set { TxtCustomersApellido.Text = value; }
        }

        public string CustomersAddress
        {
            get { return TxtCustomersDireccion.Text; }
            set { TxtCustomersDireccion.Text = value; }
        }

        public string CustomersBirthDate
        {
            get { return TxtCustomersCumple.Text; }
            set { TxtCustomersCumple.Text = value; }
        }

        public string CustomersPhoneNumber
        {
            get { return TxtCustomersCelular.Text; }
            set { TxtCustomersCelular.Text = value; }
        }

        public string CustomersEmail
        {
            get { return TxtCustomersEmail.Text; }
            set { TxtCustomersEmail.Text = value; }
        }

        public string CustomersSearchValue
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

        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            DgCustomers.DataSource = customerList;
        }

        private void SetPlaceholders()
        {
            TxtCustomersId.Text = "0";
            TxtCustomersName.Text = "Ingrese el nombre del cliente";
            TxtCustomersApellido.Text = "Ingrese el apellido del cliente";
            TxtCustomersDocumento.Text = "Ingrese el documento del cliente";
            TxtCustomersDireccion.Text = "Ingrese la dirección del cliente";
            TxtCustomersCumple.Text = "Ingrese la fecha de cumpleaños";
            TxtCustomersCelular.Text = "Ingrese el número celular";
            TxtCustomersEmail.Text = "Ingrese el email del cliente";

            // Evento para limpiar los placeholders al enfocar
            TxtCustomersId.Enter += TextBox_Enter;
            TxtCustomersName.Enter += TextBox_Enter;
            TxtCustomersApellido.Enter += TextBox_Enter;
            TxtCustomersDireccion.Enter += TextBox_Enter;
            TxtCustomersCumple.Enter += TextBox_Enter;
            TxtCustomersCelular.Enter += TextBox_Enter;
            TxtCustomersEmail.Enter += TextBox_Enter;

            // Evento para restablecer los placeholders al salir
            TxtCustomersId.Leave += TextBox_Leave;
            TxtCustomersName.Leave += TextBox_Leave;
            TxtCustomersApellido.Leave += TextBox_Leave;
            TxtCustomersDireccion.Leave += TextBox_Leave;
            TxtCustomersCumple.Leave += TextBox_Leave;
            TxtCustomersCelular.Leave += TextBox_Leave;
            TxtCustomersEmail.Leave += TextBox_Leave;
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
                if (textBox == TxtCustomersName) textBox.Text = "Ingrese el nombre del cliente";
                else if (textBox == TxtCustomersApellido) textBox.Text = "Ingrese el apellido del cliente";
                else if (textBox == TxtCustomersDocumento) textBox.Text = "Ingrese el documento del cliente";
                else if (textBox == TxtCustomersDireccion) textBox.Text = "Ingrese la dirección del cliente";
                else if (textBox == TxtCustomersCumple) textBox.Text = "Ingrese la fecha de cumpleaños";
                else if (textBox == TxtCustomersCelular) textBox.Text = "Ingrese el número celular";
                else if (textBox == TxtCustomersEmail) textBox.Text = "Ingrese el email del cliente";
            }
        }
    }
}
