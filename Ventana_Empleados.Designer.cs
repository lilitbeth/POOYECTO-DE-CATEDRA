namespace POOYECTO_DE_CATEDRA
{
    partial class Ventana_Empleados
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
            this.barraMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuConteiner1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menu2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.menuConteiner2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPeRealizados = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.transicion_menú = new System.Windows.Forms.Timer(this.components);
            this.transicion_menú2 = new System.Windows.Forms.Timer(this.components);
            this.timerbarra = new System.Windows.Forms.Timer(this.components);
            this.barraMenu.SuspendLayout();
            this.menuConteiner1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuConteiner2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.barraMenu.Controls.Add(this.menuConteiner1);
            this.barraMenu.Controls.Add(this.menuConteiner2);
            this.barraMenu.Controls.Add(this.panel2);
            this.barraMenu.Location = new System.Drawing.Point(0, 42);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(55, 482);
            this.barraMenu.TabIndex = 4;
            // 
            // menuConteiner1
            // 
            this.menuConteiner1.Controls.Add(this.panel5);
            this.menuConteiner1.Controls.Add(this.panel7);
            this.menuConteiner1.Controls.Add(this.panel3);
            this.menuConteiner1.Location = new System.Drawing.Point(3, 3);
            this.menuConteiner1.Name = "menuConteiner1";
            this.menuConteiner1.Size = new System.Drawing.Size(216, 49);
            this.menuConteiner1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.menu2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 49);
            this.panel5.TabIndex = 4;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.CadetBlue;
            this.menu2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu2.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.alt_de_inventario;
            this.menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.Location = new System.Drawing.Point(-4, -4);
            this.menu2.Name = "menu2";
            this.menu2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menu2.Size = new System.Drawing.Size(211, 59);
            this.menu2.TabIndex = 3;
            this.menu2.Text = "         Inventario ";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRealizar);
            this.panel7.Location = new System.Drawing.Point(3, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 49);
            this.panel7.TabIndex = 8;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRealizar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealizar.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.proveedor_alternativo;
            this.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizar.Location = new System.Drawing.Point(-4, -4);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRealizar.Size = new System.Drawing.Size(211, 59);
            this.btnRealizar.TabIndex = 3;
            this.btnRealizar.Text = "      Realizar inventario";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRevisar);
            this.panel3.Location = new System.Drawing.Point(3, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 49);
            this.panel3.TabIndex = 9;
            // 
            // btnRevisar
            // 
            this.btnRevisar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRevisar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRevisar.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.alt_de_inventario;
            this.btnRevisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisar.Location = new System.Drawing.Point(-4, -4);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRevisar.Size = new System.Drawing.Size(211, 59);
            this.btnRevisar.TabIndex = 3;
            this.btnRevisar.Text = "      Revisar inventario";
            this.btnRevisar.UseVisualStyleBackColor = false;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // menuConteiner2
            // 
            this.menuConteiner2.Controls.Add(this.panel4);
            this.menuConteiner2.Controls.Add(this.panel6);
            this.menuConteiner2.Location = new System.Drawing.Point(3, 58);
            this.menuConteiner2.Name = "menuConteiner2";
            this.menuConteiner2.Size = new System.Drawing.Size(216, 49);
            this.menuConteiner2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menu);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 49);
            this.panel4.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.CadetBlue;
            this.menu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.nota_medica;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-4, -4);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(211, 59);
            this.menu.TabIndex = 3;
            this.menu.Text = "         Pedidos";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnPeRealizados);
            this.panel6.Location = new System.Drawing.Point(3, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 49);
            this.panel6.TabIndex = 8;
            // 
            // btnPeRealizados
            // 
            this.btnPeRealizados.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPeRealizados.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeRealizados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPeRealizados.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.diario_alternativo;
            this.btnPeRealizados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeRealizados.Location = new System.Drawing.Point(-4, -4);
            this.btnPeRealizados.Name = "btnPeRealizados";
            this.btnPeRealizados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPeRealizados.Size = new System.Drawing.Size(211, 59);
            this.btnPeRealizados.TabIndex = 3;
            this.btnPeRealizados.Text = "      Pedidos realizados";
            this.btnPeRealizados.UseVisualStyleBackColor = false;
            this.btnPeRealizados.Click += new System.EventHandler(this.btnPeRealizados_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVolver.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.regreso_a_casa;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(-4, -4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVolver.Size = new System.Drawing.Size(217, 59);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "          Cerrar sesión ";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.UseMnemonic = false;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.panel1.TabIndex = 3;
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
            // 
            // Ventana_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 533);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Ventana_Empleados";
            this.Text = "Ventana_Empleados";
            this.Load += new System.EventHandler(this.Ventana_Empleados_Load);
            this.barraMenu.ResumeLayout(false);
            this.menuConteiner1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuConteiner2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel barraMenu;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPeRealizados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button menu2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.Timer transicion_menú;
        private System.Windows.Forms.Timer transicion_menú2;
        private System.Windows.Forms.Timer timerbarra;
    }
}