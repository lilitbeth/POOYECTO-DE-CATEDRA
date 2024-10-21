namespace POOYECTO_DE_CATEDRA
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.barraMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRePedido = new System.Windows.Forms.Button();
            this.menuConteiner2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.transicion_menú = new System.Windows.Forms.Timer(this.components);
            this.transicion_menú2 = new System.Windows.Forms.Timer(this.components);
            this.timerbarra = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuConteiner2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pupuseria Don Bosco ";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.menu_hamburguesa__2_;
            this.btnMenu.Location = new System.Drawing.Point(6, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 30);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.barraMenu.Controls.Add(this.panel4);
            this.barraMenu.Controls.Add(this.menuConteiner2);
            this.barraMenu.Controls.Add(this.panel2);
            this.barraMenu.Location = new System.Drawing.Point(0, 44);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(260, 488);
            this.barraMenu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRePedido);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 49);
            this.panel4.TabIndex = 7;
            // 
            // btnRePedido
            // 
            this.btnRePedido.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRePedido.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRePedido.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.diario_alternativo;
            this.btnRePedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRePedido.Location = new System.Drawing.Point(-4, -4);
            this.btnRePedido.Name = "btnRePedido";
            this.btnRePedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRePedido.Size = new System.Drawing.Size(211, 59);
            this.btnRePedido.TabIndex = 3;
            this.btnRePedido.Text = "          Realizar pedido";
            this.btnRePedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRePedido.UseMnemonic = false;
            this.btnRePedido.UseVisualStyleBackColor = false;
            this.btnRePedido.Click += new System.EventHandler(this.btnRePedido_Click);
            // 
            // menuConteiner2
            // 
            this.menuConteiner2.Controls.Add(this.panel3);
            this.menuConteiner2.Controls.Add(this.panel5);
            this.menuConteiner2.Location = new System.Drawing.Point(3, 58);
            this.menuConteiner2.Name = "menuConteiner2";
            this.menuConteiner2.Size = new System.Drawing.Size(210, 49);
            this.menuConteiner2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menu2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 49);
            this.panel3.TabIndex = 6;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.CadetBlue;
            this.menu2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu2.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.usuarios_alt;
            this.menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.Location = new System.Drawing.Point(-4, -4);
            this.menu2.Name = "menu2";
            this.menu2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menu2.Size = new System.Drawing.Size(211, 59);
            this.menu2.TabIndex = 3;
            this.menu2.Text = "         Empleados";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.UseVisualStyleBackColor = false;
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLogin);
            this.panel5.Location = new System.Drawing.Point(3, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 49);
            this.panel5.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.alt_de_inicio_de_sesion__1_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(-4, -4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(211, 59);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "    Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAcerca);
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 49);
            this.panel2.TabIndex = 5;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAcerca.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcerca.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.informacion_del_circulo_de_archivos__1_;
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(-4, -4);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAcerca.Size = new System.Drawing.Size(211, 59);
            this.btnAcerca.TabIndex = 3;
            this.btnAcerca.Text = "          Acerca de";
            this.btnAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.UseMnemonic = false;
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // transicion_menú2
            // 
            this.transicion_menú2.Tick += new System.EventHandler(this.transicion_menú2_Tick);
            // 
            // timerbarra
            // 
            this.timerbarra.Tick += new System.EventHandler(this.timerbarra_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1056, 533);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Pupuseria Don Bosco ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuConteiner2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel barraMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button menu2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner2;
        private System.Windows.Forms.Timer transicion_menú;
        private System.Windows.Forms.Timer transicion_menú2;
        private System.Windows.Forms.Timer timerbarra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRePedido;
    }
}

