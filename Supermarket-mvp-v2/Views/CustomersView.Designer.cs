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
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            DgCustomers = new DataGridView();
            BtnClose = new Button();
            BtnSearch = new Button();
            BtnDelete = new Button();
            label2 = new Label();
            BtnEdit = new Button();
            TxtSearch = new TextBox();
            BtnNew = new Button();
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 208);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 456);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(1008, 423);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List ";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(46, 84);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(646, 301);
            DgCustomers.TabIndex = 23;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(748, 330);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 22;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(631, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(748, 247);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 55);
            BtnDelete.TabIndex = 21;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 15);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 16;
            label2.Text = "Search Customers";
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(748, 164);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 55);
            BtnEdit.TabIndex = 20;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(55, 38);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(557, 27);
            TxtSearch.TabIndex = 17;
            TxtSearch.Text = "Data to search";
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(748, 84);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 55);
            BtnNew.TabIndex = 19;
            BtnNew.UseVisualStyleBackColor = true;
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
            tabPageCustomersDetail.Size = new Size(1008, 423);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Deatail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(544, 270);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.Size = new Size(364, 27);
            TxtCustomersEmail.TabIndex = 39;
            TxtCustomersEmail.Text = "Ingrese el email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(544, 247);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 38;
            label10.Text = "Customers Email";
            // 
            // TxtCustomersCelular
            // 
            TxtCustomersCelular.Location = new Point(544, 196);
            TxtCustomersCelular.Name = "TxtCustomersCelular";
            TxtCustomersCelular.Size = new Size(364, 27);
            TxtCustomersCelular.TabIndex = 37;
            TxtCustomersCelular.Text = "Ingrese el celular";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 173);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 36;
            label9.Text = "Customers Celular";
            // 
            // TxtCustomersApellido
            // 
            TxtCustomersApellido.Location = new Point(46, 292);
            TxtCustomersApellido.Name = "TxtCustomersApellido";
            TxtCustomersApellido.Size = new Size(364, 27);
            TxtCustomersApellido.TabIndex = 35;
            TxtCustomersApellido.Text = "Ingrese el apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 269);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 34;
            label8.Text = "Customers Last Name";
            // 
            // TxtCustomersCumple
            // 
            TxtCustomersCumple.Location = new Point(544, 124);
            TxtCustomersCumple.Name = "TxtCustomersCumple";
            TxtCustomersCumple.Size = new Size(364, 27);
            TxtCustomersCumple.TabIndex = 33;
            TxtCustomersCumple.Text = "Ingrese el cumpleaños";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 101);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 32;
            label7.Text = "Customers Cumpleaños";
            // 
            // TxtCustomersDireccion
            // 
            TxtCustomersDireccion.Location = new Point(544, 58);
            TxtCustomersDireccion.Name = "TxtCustomersDireccion";
            TxtCustomersDireccion.Size = new Size(364, 27);
            TxtCustomersDireccion.TabIndex = 31;
            TxtCustomersDireccion.Text = "Ingrese la dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 35);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 30;
            label6.Text = "Customers Direccion";
            // 
            // TxtCustomersName
            // 
            TxtCustomersName.Location = new Point(46, 206);
            TxtCustomersName.Name = "TxtCustomersName";
            TxtCustomersName.Size = new Size(364, 27);
            TxtCustomersName.TabIndex = 29;
            TxtCustomersName.Text = "Ingrese el nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 183);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 28;
            label5.Text = "Customers Name";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(816, 332);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(92, 59);
            BtnCancel.TabIndex = 27;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(701, 332);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 59);
            BtnSave.TabIndex = 26;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersDocumento
            // 
            TxtCustomersDocumento.Location = new Point(46, 130);
            TxtCustomersDocumento.Name = "TxtCustomersDocumento";
            TxtCustomersDocumento.Size = new Size(364, 27);
            TxtCustomersDocumento.TabIndex = 25;
            TxtCustomersDocumento.Text = "Ingrese el número de Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 107);
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
            label3.Location = new Point(46, 29);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 22;
            label3.Text = "Customers Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 95);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "CUSTOMERS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.satisfaccion_del_cliente;
            pictureBox1.Location = new Point(50, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 664);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "CustomersView";
            Text = "CustomersView";
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnClose;
        private Button BtnSearch;
        private Button BtnDelete;
        private Label label2;
        private Button BtnEdit;
        private TextBox TxtSearch;
        private Button BtnNew;
        private DataGridView DgCustomers;
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
        private TextBox TxtCustomersEmail;
        private Label label10;
        private TextBox TxtCustomersCelular;
        private Label label9;
    }
}