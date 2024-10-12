namespace Supermarket_mvp_v2.Views
{
    partial class CustomersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgCustomers = new DataGridView();
            BtnClose = new Button();
            BtnSearch = new Button();
            BtnDelete = new Button();
            label2 = new Label();
            BtnEdit = new Button();
            TxtSearch = new TextBox();
            BtnNew = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            tabPageCustomersDetail = new TabPage();
            TxtCustomersEmail = new TextBox();
            label10 = new Label();
            TxtCustomersCelular = new TextBox();
            label9 = new Label();
            TxtCustomersApellido = new TextBox();
            label8 = new Label();
            TxtCustomersCumple = new TextBox();
            label7 = new Label();
            TxtCustomersDireccion = new TextBox();
            label6 = new Label();
            TxtCustomersName = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomersDocumento = new TextBox();
            label4 = new Label();
            TxtCustomersId = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            tabPageCustomersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(67, 97);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(647, 305);
            DgCustomers.TabIndex = 23;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(745, 349);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 22;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.buscar2;
            BtnSearch.Location = new Point(644, 20);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.eliminar_carpeta2;
            BtnDelete.Location = new Point(745, 263);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 55);
            BtnDelete.TabIndex = 21;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 20);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 16;
            label2.Text = "Search Customers";
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.carpetaediat2;
            BtnEdit.Location = new Point(745, 184);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 55);
            BtnEdit.TabIndex = 20;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(67, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(557, 27);
            TxtSearch.TabIndex = 17;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources.agregar2;
            BtnNew.Location = new Point(745, 97);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 55);
            BtnNew.TabIndex = 19;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 710);
            panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Location = new Point(0, 190);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 520);
            tabControl1.TabIndex = 24;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(1008, 487);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List ";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(TxtCustomersCelular);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(TxtCustomersApellido);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(TxtCustomersCumple);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDireccion);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(TxtCustomersName);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(BtnCancel);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDocumento);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 29);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(1008, 487);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Deatail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(547, 292);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.PlaceholderText = "Ingrese el email";
            TxtCustomersEmail.Size = new Size(364, 27);
            TxtCustomersEmail.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(550, 272);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 38;
            label10.Text = "Customers Email";
            // 
            // TxtCustomersCelular
            // 
            TxtCustomersCelular.Location = new Point(544, 206);
            TxtCustomersCelular.Name = "TxtCustomersCelular";
            TxtCustomersCelular.PlaceholderText = "Ingrese el celular";
            TxtCustomersCelular.Size = new Size(364, 27);
            TxtCustomersCelular.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(547, 186);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 36;
            label9.Text = "Customers Celular";
            // 
            // TxtCustomersApellido
            // 
            TxtCustomersApellido.Location = new Point(46, 292);
            TxtCustomersApellido.Name = "TxtCustomersApellido";
            TxtCustomersApellido.PlaceholderText = "Ingrese el apellido";
            TxtCustomersApellido.Size = new Size(364, 27);
            TxtCustomersApellido.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 272);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 34;
            label8.Text = "Customers Last Name";
            // 
            // TxtCustomersCumple
            // 
            TxtCustomersCumple.Location = new Point(544, 130);
            TxtCustomersCumple.Name = "TxtCustomersCumple";
            TxtCustomersCumple.PlaceholderText = "YYYY-MM-DD";
            TxtCustomersCumple.Size = new Size(364, 27);
            TxtCustomersCumple.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 110);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 32;
            label7.Text = "Customers Cumpleaños";
            // 
            // TxtCustomersDireccion
            // 
            TxtCustomersDireccion.Location = new Point(544, 58);
            TxtCustomersDireccion.Name = "TxtCustomersDireccion";
            TxtCustomersDireccion.PlaceholderText = "Ingrese la dirección";
            TxtCustomersDireccion.Size = new Size(364, 27);
            TxtCustomersDireccion.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 38);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 30;
            label6.Text = "Customers Direccion";
            // 
            // TxtCustomersName
            // 
            TxtCustomersName.Location = new Point(46, 206);
            TxtCustomersName.Name = "TxtCustomersName";
            TxtCustomersName.PlaceholderText = "Ingrese el nombre";
            TxtCustomersName.Size = new Size(364, 27);
            TxtCustomersName.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 186);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 28;
            label5.Text = "Customers Name";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(730, 352);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(92, 59);
            BtnCancel.TabIndex = 27;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(615, 352);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 59);
            BtnSave.TabIndex = 26;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersDocumento
            // 
            TxtCustomersDocumento.Location = new Point(46, 130);
            TxtCustomersDocumento.Name = "TxtCustomersDocumento";
            TxtCustomersDocumento.PlaceholderText = "Ingrese el número de Documento";
            TxtCustomersDocumento.Size = new Size(364, 27);
            TxtCustomersDocumento.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 110);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 24;
            label4.Text = "Products Document";
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(46, 52);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(221, 27);
            TxtCustomersId.TabIndex = 23;
            TxtCustomersId.Text = "0";
            TxtCustomersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 32);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 22;
            label3.Text = "Customers Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.satisfaccion_del_cliente;
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 74);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "CUSTOMERS";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 712);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "CustomersView";
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnClose;
        private Button BtnSearch;
        private Button BtnDelete;
        private Label label2;
        private Button BtnEdit;
        private TextBox TxtSearch;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private TextBox TxtCustomersEmail;
        private Label label10;
        private TextBox TxtCustomersCelular;
        private Label label9;
        private TextBox TxtCustomersApellido;
        private Label label8;
        private TextBox TxtCustomersCumple;
        private Label label7;
        private TextBox TxtCustomersDireccion;
        private Label label6;
        private TextBox TxtCustomersName;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomersDocumento;
        private Label label4;
        private TextBox TxtCustomersId;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}