namespace Supermarket_mvp_v2.Views
{
    partial class ProductsView
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
            tabPageProductsList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            TxtProductsCategoria = new TextBox();
            label7 = new Label();
            TxtProductsStock = new TextBox();
            label6 = new Label();
            TxtProductsPrecio = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductsName = new TextBox();
            label4 = new Label();
            TxtProductsId = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 216);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1100, 439);
            tabControl1.TabIndex = 0;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(1092, 406);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(789, 333);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.eliminar_carpeta1;
            BtnDelete.Location = new Point(789, 251);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 55);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.carpetaediat1;
            BtnEdit.Location = new Point(789, 167);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 55);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources.agregar1;
            BtnNew.Location = new Point(789, 87);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 55);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(90, 87);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.Size = new Size(646, 301);
            DgProducts.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.buscar1;
            BtnSearch.Location = new Point(666, 19);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(90, 42);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(557, 27);
            TxtSearch.TabIndex = 9;
            TxtSearch.Text = "Data to search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 19);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtProductsCategoria);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(TxtProductsStock);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(TxtProductsPrecio);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(1092, 406);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductsCategoria
            // 
            TxtProductsCategoria.Location = new Point(598, 140);
            TxtProductsCategoria.Name = "TxtProductsCategoria";
            TxtProductsCategoria.Size = new Size(364, 27);
            TxtProductsCategoria.TabIndex = 21;
            TxtProductsCategoria.Text = "Ingrese la categoria ID del producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 117);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 20;
            label7.Text = "Categoria ID Precio";
            // 
            // TxtProductsStock
            // 
            TxtProductsStock.Location = new Point(598, 62);
            TxtProductsStock.Name = "TxtProductsStock";
            TxtProductsStock.Size = new Size(364, 27);
            TxtProductsStock.TabIndex = 19;
            TxtProductsStock.Text = "Ingrese el stock del producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(598, 39);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 18;
            label6.Text = "Products Stock";
            // 
            // TxtProductsPrecio
            // 
            TxtProductsPrecio.Location = new Point(155, 220);
            TxtProductsPrecio.Name = "TxtProductsPrecio";
            TxtProductsPrecio.Size = new Size(364, 27);
            TxtProductsPrecio.TabIndex = 17;
            TxtProductsPrecio.Text = "Ingrese el precio del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 197);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "Products Precio";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(542, 333);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(92, 59);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(427, 333);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 59);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(155, 144);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.Size = new Size(364, 27);
            TxtProductsName.TabIndex = 11;
            TxtProductsName.Text = "Ingrese el nombre del método de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 121);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 10;
            label4.Text = "Products Name";
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(155, 66);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(221, 27);
            TxtProductsId.TabIndex = 9;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 43);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Products Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descuento;
            pictureBox1.Location = new Point(50, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 99);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "PRODUCTS";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 655);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "ProductsView";
            Text = "ProductsView";
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProductsCategoria;
        private Label label7;
        private TextBox TxtProductsStock;
        private Label label6;
        private TextBox TxtProductsPrecio;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Label label3;
    }
}