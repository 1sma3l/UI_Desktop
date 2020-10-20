namespace UI_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSelling = new FontAwesome.Sharp.IconButton();
            this.btnMarketing = new FontAwesome.Sharp.IconButton();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnDash = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildFrom = new System.Windows.Forms.Label();
            this.iconCurrentChildrenFrom = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHr = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildrenFrom)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSelling);
            this.panelMenu.Controls.Add(this.btnMarketing);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnDash);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnSelling
            // 
            resources.ApplyResources(this.btnSelling, "btnSelling");
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSelling.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelling.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnSelling.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSelling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelling.IconSize = 32;
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Rotation = 0D;
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnMarketing
            // 
            resources.ApplyResources(this.btnMarketing, "btnMarketing");
            this.btnMarketing.FlatAppearance.BorderSize = 0;
            this.btnMarketing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnMarketing.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarketing.IconSize = 32;
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Rotation = 0D;
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnProducts
            // 
            resources.ApplyResources(this.btnProducts, "btnProducts");
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 32;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Rotation = 0D;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrder
            // 
            resources.ApplyResources(this.btnOrder, "btnOrder");
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 32;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Rotation = 0D;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDash
            // 
            resources.ApplyResources(this.btnDash, "btnDash");
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDash.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDash.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDash.IconSize = 32;
            this.btnDash.Name = "btnDash";
            this.btnDash.Rotation = 0D;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::UI_Desktop.Properties.Resources.inicio;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildFrom);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildrenFrom);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildFrom
            // 
            resources.ApplyResources(this.lblTitleChildFrom, "lblTitleChildFrom");
            this.lblTitleChildFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildFrom.Name = "lblTitleChildFrom";
            // 
            // iconCurrentChildrenFrom
            // 
            this.iconCurrentChildrenFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildrenFrom.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildrenFrom.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildrenFrom.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildrenFrom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildrenFrom.IconSize = 50;
            resources.ApplyResources(this.iconCurrentChildrenFrom, "iconCurrentChildrenFrom");
            this.iconCurrentChildrenFrom.Name = "iconCurrentChildrenFrom";
            this.iconCurrentChildrenFrom.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            resources.ApplyResources(this.panelShadow, "panelShadow");
            this.panelShadow.Name = "panelShadow";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Name = "lblFecha";
            // 
            // lblHora
            // 
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHora.Name = "lblHora";
            // 
            // timerHr
            // 
            this.timerHr.Interval = 10;
            this.timerHr.Tick += new System.EventHandler(this.timerHr_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildrenFrom)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDash;
        private FontAwesome.Sharp.IconButton btnSelling;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildrenFrom;
        private System.Windows.Forms.Label lblTitleChildFrom;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHr;
    }
}

