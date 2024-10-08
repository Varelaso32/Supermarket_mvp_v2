namespace Supermarket_mvp_v2.Views
{
    partial class PayModeView
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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 231);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 470);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgPayMode);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pay Mode List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModeId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(969, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 99);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "PAY MODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(21, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 32);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(17, 55);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(557, 27);
            TxtSearch.TabIndex = 1;
            TxtSearch.Text = "Data to search";
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(593, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 52);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(17, 100);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(646, 301);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(716, 100);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(213, 55);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(716, 180);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(213, 55);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(716, 264);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(213, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(716, 346);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(213, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 37);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(17, 60);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(221, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(17, 138);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(364, 27);
            TxtPayModeName.TabIndex = 3;
            TxtPayModeName.Text = "Pay Mode Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 115);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(17, 214);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(374, 115);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 191);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(85, 355);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 59);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(200, 355);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(92, 59);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 701);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "PayModeView";
            Text = "PayModeView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
        private Button BtnCancel;
    }
}