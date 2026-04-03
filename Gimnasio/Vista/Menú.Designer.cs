namespace Gimnasio
{
    partial class Menu
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
            this.panel_botones = new System.Windows.Forms.Panel();
            this.pagos = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.gestionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.Controls.Add(this.pagos);
            this.panel_botones.Controls.Add(this.salir);
            this.panel_botones.Controls.Add(this.gestionar);
            this.panel_botones.Location = new System.Drawing.Point(572, 142);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(282, 309);
            this.panel_botones.TabIndex = 17;
            // 
            // pagos
            // 
            this.pagos.BackColor = System.Drawing.Color.Yellow;
            this.pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagos.Location = new System.Drawing.Point(58, 111);
            this.pagos.Name = "pagos";
            this.pagos.Size = new System.Drawing.Size(177, 53);
            this.pagos.TabIndex = 3;
            this.pagos.Text = "Pagos del día";
            this.pagos.UseVisualStyleBackColor = false;
            this.pagos.Click += new System.EventHandler(this.pagos_Click);
            this.pagos.MouseEnter += new System.EventHandler(this.btnExample_MouseEnter);
            this.pagos.MouseLeave += new System.EventHandler(this.btnExample_MouseLeave);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.Control;
            this.salir.Location = new System.Drawing.Point(58, 235);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(177, 53);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.btnExample_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.btnExample_MouseLeave);
            // 
            // gestionar
            // 
            this.gestionar.BackColor = System.Drawing.Color.Lime;
            this.gestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionar.Location = new System.Drawing.Point(58, 24);
            this.gestionar.Name = "gestionar";
            this.gestionar.Size = new System.Drawing.Size(177, 53);
            this.gestionar.TabIndex = 1;
            this.gestionar.Text = "Gestionar Persona";
            this.gestionar.UseVisualStyleBackColor = false;
            this.gestionar.Click += new System.EventHandler(this.gestionar_Click);
            this.gestionar.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.gestionar.MouseEnter += new System.EventHandler(this.btnExample_MouseEnter);
            this.gestionar.MouseLeave += new System.EventHandler(this.btnExample_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gimnasio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_3
            // 
            this.panel_3.BackgroundImage = global::Gimnasio.Properties.Resources.Peso_muerto;
            this.panel_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_3.Location = new System.Drawing.Point(1071, 0);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(315, 290);
            this.panel_3.TabIndex = 17;
            // 
            // panel_2
            // 
            this.panel_2.BackgroundImage = global::Gimnasio.Properties.Resources.Mancuernas_2;
            this.panel_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_2.Location = new System.Drawing.Point(3, 497);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(315, 290);
            this.panel_2.TabIndex = 19;
            // 
            // panel_4
            // 
            this.panel_4.BackgroundImage = global::Gimnasio.Properties.Resources.press_de_banca;
            this.panel_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_4.Location = new System.Drawing.Point(1013, 497);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(315, 290);
            this.panel_4.TabIndex = 18;
            // 
            // panel_1
            // 
            this.panel_1.BackgroundImage = global::Gimnasio.Properties.Resources.Mancuernas;
            this.panel_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_1.Location = new System.Drawing.Point(3, 0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(315, 290);
            this.panel_1.TabIndex = 16;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1326, 563);
            this.Controls.Add(this.panel_3);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_4);
            this.Controls.Add(this.panel_botones);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Gimnasio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.menu_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu_KeyDown);
            this.panel_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button gestionar;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pagos;
        private System.Windows.Forms.Panel panel_3;
    }
}

