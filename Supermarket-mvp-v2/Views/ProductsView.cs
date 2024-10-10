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
            public event EventHandler LoadAllPayModesEvent;

        public ProductsView()
            {
                InitializeComponent();
                AssociateAndRaiseViewEvents();
                tabControl1.TabPages.Remove(tabPageProductsDetail);

                SetPlaceholders();
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

                BtnNew.Click += delegate {
                    AddNewEvent?.Invoke(this, EventArgs.Empty);
                    ClearSearchBox();
                    tabControl1.TabPages.Remove(tabPageProductsList);
                    tabControl1.TabPages.Add(tabPageProductsDetail);
                    tabPageProductsDetail.Text = "Añadir nuevo producto";
                    LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);

                };//

                BtnEdit.Click += delegate {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    ClearSearchBox();

                    tabControl1.TabPages.Remove(tabPageProductsList);
                    tabControl1.TabPages.Add(tabPageProductsDetail);
                    tabPageProductsDetail.Text = "Editar producto";
                    LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);
                };//

                BtnSave.Click += delegate {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    if (isSuccessful)
                    {
                        tabControl1.TabPages.Remove(tabPageProductsDetail);
                        tabControl1.TabPages.Add(tabPageProductsList);
                    }
                    MessageBox.Show(Message);
                };//

                BtnCancel.Click += delegate {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageProductsDetail);
                    tabControl1.TabPages.Add(tabPageProductsList);
                };//

                BtnDelete.Click += delegate {
                    var result = MessageBox.Show(
                        "¿Está seguro de que desea eliminar el producto seleccionado?",
                        "Advertencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);
                        ClearSearchBox();
                        LoadAllPayModesEvent?.Invoke(this, EventArgs.Empty);
                    }
                };//

                TxtSearch.Click += delegate
                {
                    TxtSearch.Clear();
                };//
            }

            public string ProductId
            {
                get { return TxtProductsId.Text; }
                set { TxtProductsId.Text = value; }

            }//Fin de la clase

            public string ProductName
            {
                get { return TxtProductsName.Text; }
                set { TxtProductsName.Text = value; }

            }//Fin de la clase

            public string ProductPrice
            {
                get { return TxtProductsPrecio.Text; }
                set { TxtProductsPrecio.Text = value; }

            }//Fin de la clase

            public string ProductStock
            {
                get { return TxtProductsStock.Text; }
                set { TxtProductsStock.Text = value; }

            }//Fin de la clase

            public string ProductCategoryId
            {
                get { return TxtProductsCategoria.Text; }
                set { TxtProductsCategoria.Text = value; }

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

            public void SetProductListBindingSource(BindingSource productList)
            {
                DgProducts.DataSource = productList;

            }//Fin de la clase

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

            public new void Show()
            {
                base.Show();

            }//Fin de la clase

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

            }//Fin de la clase
            private void ClearSearchBox()
            {
                TxtSearch.Text = "Ingrese el término de búsqueda";

            }//Fin de la clase
            private void TextBox_Enter(object sender, EventArgs e)
            {
                TextBox textBox = (TextBox)sender;
                textBox.SelectAll();
                if (textBox.Text.Contains("Ingrese"))
                {
                    textBox.Text = "";
                }

            }//Fin de la clase

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

            }//Fin de la clase

            private void ClearSearchAndFields()
            {
                TxtSearch.Text = "Buscar...";
                TxtProductsId.Text = "0";
                TxtProductsName.Text = "Ingrese el nombre del producto";
                TxtProductsPrecio.Text = "Ingrese el precio del producto";
                TxtProductsStock.Text = "Ingrese el stock del producto";
                TxtProductsCategoria.Text = "Ingrese el ID de la categoría";

            }//Fin de la clase
        }
    }
