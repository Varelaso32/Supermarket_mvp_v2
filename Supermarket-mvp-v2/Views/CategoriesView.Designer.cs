namespace Supermarket_mvp_v2.Views
{
    partial class CategoriesView
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
            tabPageCategoriesList = new TabPage();
            tabPageCategoriesDetail = new TabPage();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnClose = new Button();
            BtnSearch = new Button();
            BtnDelete = new Button();
            label2 = new Label();
            BtnEdit = new Button();
            TxtSearch = new TextBox();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            tabPageCategoriesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 228);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(997, 431);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(DgCustomers);
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(989, 398);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Customers List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(TxtPayModeObservation);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(TxtPayModeName);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(TxtPayModeId);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(989, 398);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Customers Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categories2;
            pictureBox1.Location = new Point(53, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 111);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "CATEGORIES";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(725, 301);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 29;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(574, 23);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 25;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(725, 230);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 55);
            BtnDelete.TabIndex = 28;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 23);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 23;
            label2.Text = "Search Pay Mode";
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(725, 164);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 55);
            BtnEdit.TabIndex = 27;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(39, 46);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(516, 27);
            TxtSearch.TabIndex = 24;
            TxtSearch.Text = "Data to search";
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(725, 91);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 55);
            BtnNew.TabIndex = 26;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(39, 91);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(617, 265);
            DgCustomers.TabIndex = 30;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(490, 329);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(92, 59);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(375, 329);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 59);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(307, 188);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(374, 115);
            TxtPayModeObservation.TabIndex = 13;
            TxtPayModeObservation.Text = "Ingrese la descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 165);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 12;
            label5.Text = "Categories Description";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(307, 112);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(364, 27);
            TxtPayModeName.TabIndex = 11;
            TxtPayModeName.Text = "Ingrese el el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 89);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 10;
            label4.Text = "Categories Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(307, 34);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(221, 27);
            TxtPayModeId.TabIndex = 9;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 11);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Categories Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 659);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnClose;
        private Button BtnSearch;
        private Button BtnDelete;
        private Label label2;
        private Button BtnEdit;
        private TextBox TxtSearch;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
    }
}