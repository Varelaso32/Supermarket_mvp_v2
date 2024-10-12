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
            DgProducts = new DataGridView();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            TxtProductsCategoria = new TextBox();
            TxtProductsStock = new TextBox();
            TxtProductsPrecio = new TextBox();
            TxtProductsName = new TextBox();
            TxtProductsId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            tabPageProductsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(98, 105);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.Size = new Size(648, 281);
            DgProducts.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 643);
            panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Location = new Point(0, 195);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1100, 448);
            tabControl1.TabIndex = 16;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(1092, 415);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.eliminar_carpeta1;
            BtnDelete.Location = new Point(819, 257);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 46);
            BtnDelete.TabIndex = 17;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(819, 326);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources.agregar1;
            BtnNew.Location = new Point(819, 110);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 46);
            BtnNew.TabIndex = 15;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.carpetaediat1;
            BtnEdit.Location = new Point(819, 185);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 46);
            BtnEdit.TabIndex = 16;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(98, 50);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(557, 27);
            TxtSearch.TabIndex = 9;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.buscar1;
            BtnSearch.Location = new Point(676, 25);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 25);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtProductsCategoria);
            tabPageProductsDetail.Controls.Add(TxtProductsStock);
            tabPageProductsDetail.Controls.Add(TxtProductsPrecio);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(1092, 415);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductsCategoria
            // 
            TxtProductsCategoria.Location = new Point(598, 140);
            TxtProductsCategoria.Name = "TxtProductsCategoria";
            TxtProductsCategoria.PlaceholderText = "Ingrese la categoria ID del producto";
            TxtProductsCategoria.Size = new Size(364, 27);
            TxtProductsCategoria.TabIndex = 21;
            // 
            // TxtProductsStock
            // 
            TxtProductsStock.Location = new Point(598, 62);
            TxtProductsStock.Name = "TxtProductsStock";
            TxtProductsStock.PlaceholderText = "Ingrese el stock del producto";
            TxtProductsStock.Size = new Size(364, 27);
            TxtProductsStock.TabIndex = 19;
            // 
            // TxtProductsPrecio
            // 
            TxtProductsPrecio.Location = new Point(155, 220);
            TxtProductsPrecio.Name = "TxtProductsPrecio";
            TxtProductsPrecio.PlaceholderText = "Ingrese el precio del producto";
            TxtProductsPrecio.Size = new Size(364, 27);
            TxtProductsPrecio.TabIndex = 17;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(155, 144);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Ingrese el nombre del método de pago";
            TxtProductsName.Size = new Size(364, 27);
            TxtProductsName.TabIndex = 11;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(601, 120);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 20;
            label7.Text = "Categoria ID Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(601, 42);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 18;
            label6.Text = "Products Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 200);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 124);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 10;
            label4.Text = "Products Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 46);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Products Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descuento;
            pictureBox1.Location = new Point(48, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 88);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "PRODUCTS";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 655);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DgProducts;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
        private Button BtnEdit;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Label label2;
        private TabPage tabPageProductsDetail;
        private TextBox TxtProductsCategoria;
        private TextBox TxtProductsStock;
        private TextBox TxtProductsPrecio;
        private TextBox TxtProductsName;
        private TextBox TxtProductsId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label4;
        private Label label3;
    }
}