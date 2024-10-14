namespace Supermarket_mvp_v2.Views
{
    partial class MainView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            BtnCategories = new Button();
            BtnCustomers = new Button();
            BtnProducts = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 850);
            panel1.TabIndex = 0;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.categorias1;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(0, 548);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(250, 150);
            BtnCategories.TabIndex = 5;
            toolTip1.SetToolTip(BtnCategories, "Ingresar a las categorias");
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.satisfaccion_del_cliente1;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(0, 395);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(250, 150);
            BtnCustomers.TabIndex = 4;
            toolTip1.SetToolTip(BtnCustomers, "Registrar clientes");
            BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.descuento1;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(0, 242);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(250, 150);
            BtnProducts.TabIndex = 3;
            toolTip1.SetToolTip(BtnProducts, "Ingresar a los productos");
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar_sesion;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 700);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(250, 150);
            BtnExit.TabIndex = 2;
            toolTip1.SetToolTip(BtnExit, "Cerrar sección");
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnPayMode.BackgroundImage = Properties.Resources.comercio1;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 90);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(250, 150);
            BtnPayMode.TabIndex = 1;
            toolTip1.SetToolTip(BtnPayMode, "Ingresar al metodo de pago");
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoGoku1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 850);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnProducts;
        private Button BtnCustomers;
        private Button BtnCategories;
        private ToolTip toolTip1;
    }
}