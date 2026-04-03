namespace Gimnasio.Vista
{
    partial class Gestionar_Persona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.guardar_cambios = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label_buscar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.color = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_pago = new System.Windows.Forms.DateTimePicker();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vaciar = new System.Windows.Forms.Button();
            this.panel_vistaPrevia = new System.Windows.Forms.Panel();
            this.abrir_cámara = new System.Windows.Forms.Button();
            this.capturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_botones.SuspendLayout();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(53, 357);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_botones.Controls.Add(this.Cancelar);
            this.panel_botones.Controls.Add(this.guardar_cambios);
            this.panel_botones.Controls.Add(this.eliminar);
            this.panel_botones.Controls.Add(this.Modificar);
            this.panel_botones.Controls.Add(this.Agregar);
            this.panel_botones.Location = new System.Drawing.Point(988, 76);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(370, 219);
            this.panel_botones.TabIndex = 18;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Red;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancelar.Location = new System.Drawing.Point(212, 145);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(144, 53);
            this.Cancelar.TabIndex = 30;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // guardar_cambios
            // 
            this.guardar_cambios.BackColor = System.Drawing.Color.Lime;
            this.guardar_cambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_cambios.Location = new System.Drawing.Point(21, 20);
            this.guardar_cambios.Name = "guardar_cambios";
            this.guardar_cambios.Size = new System.Drawing.Size(144, 53);
            this.guardar_cambios.TabIndex = 4;
            this.guardar_cambios.Text = "Guardar cambios";
            this.guardar_cambios.UseVisualStyleBackColor = false;
            this.guardar_cambios.Visible = false;
            this.guardar_cambios.Click += new System.EventHandler(this.guardar_cambios_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Red;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminar.Location = new System.Drawing.Point(212, 19);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(144, 53);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.Gold;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(21, 145);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(144, 53);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.Lime;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(21, 19);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(144, 53);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.Control;
            this.salir.Location = new System.Drawing.Point(973, 322);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(144, 53);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.btnExample_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.btnExample_MouseLeave);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(1109, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 29);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label_buscar
            // 
            this.label_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.Location = new System.Drawing.Point(1110, 6);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(143, 26);
            this.label_buscar.TabIndex = 20;
            this.label_buscar.Text = "Buscar";
            this.label_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 73);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 29);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(141, 131);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(116, 29);
            this.txtEdad.TabIndex = 26;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Edad";
            // 
            // panel_campos
            // 
            this.panel_campos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_campos.Controls.Add(this.color);
            this.panel_campos.Controls.Add(this.label11);
            this.panel_campos.Controls.Add(this.txtPeso);
            this.panel_campos.Controls.Add(this.label10);
            this.panel_campos.Controls.Add(this.txtEstatura);
            this.panel_campos.Controls.Add(this.label9);
            this.panel_campos.Controls.Add(this.label8);
            this.panel_campos.Controls.Add(this.txtID);
            this.panel_campos.Controls.Add(this.label6);
            this.panel_campos.Controls.Add(this.fecha_pago);
            this.panel_campos.Controls.Add(this.sexo);
            this.panel_campos.Controls.Add(this.label7);
            this.panel_campos.Controls.Add(this.txtDireccion);
            this.panel_campos.Controls.Add(this.label5);
            this.panel_campos.Controls.Add(this.txtTelefono);
            this.panel_campos.Controls.Add(this.label4);
            this.panel_campos.Controls.Add(this.txtEdad);
            this.panel_campos.Controls.Add(this.label3);
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Controls.Add(this.txtNombre);
            this.panel_campos.Location = new System.Drawing.Point(29, 26);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(683, 303);
            this.panel_campos.TabIndex = 27;
            // 
            // color
            // 
            this.color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Muy claro",
            "Claro",
            "Trigueño claro",
            "Trigueño medio",
            "Trigueño oscuro",
            "Moreno",
            "Oscuro"});
            this.color.Location = new System.Drawing.Point(485, 75);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(132, 26);
            this.color.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 29);
            this.label11.TabIndex = 46;
            this.label11.Text = "Color de piel";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(485, 17);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(116, 29);
            this.txtPeso.TabIndex = 45;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "Peso (Kg)";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(141, 253);
            this.txtEstatura.Multiline = true;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(116, 29);
            this.txtEstatura.TabIndex = 43;
            this.txtEstatura.TextChanged += new System.EventHandler(this.txtEstatura_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 42;
            this.label9.Text = "Estatura (m)";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 17);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 29);
            this.txtID.TabIndex = 41;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha de registro";
            // 
            // fecha_pago
            // 
            this.fecha_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_pago.Location = new System.Drawing.Point(485, 261);
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.Size = new System.Drawing.Size(174, 26);
            this.fecha_pago.TabIndex = 38;
            // 
            // sexo
            // 
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.sexo.Location = new System.Drawing.Point(141, 191);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(116, 28);
            this.sexo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sexo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(485, 197);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(116, 29);
            this.txtDireccion.TabIndex = 30;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(485, 136);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 29);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teléfono";
            // 
            // vaciar
            // 
            this.vaciar.BackColor = System.Drawing.Color.Red;
            this.vaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaciar.ForeColor = System.Drawing.Color.White;
            this.vaciar.Location = new System.Drawing.Point(1074, 332);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(144, 53);
            this.vaciar.TabIndex = 4;
            this.vaciar.Text = "Vaciar lista";
            this.vaciar.UseVisualStyleBackColor = false;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            this.vaciar.MouseEnter += new System.EventHandler(this.btnExample_MouseEnter);
            this.vaciar.MouseLeave += new System.EventHandler(this.btnExample_MouseLeave);
            // 
            // panel_vistaPrevia
            // 
            this.panel_vistaPrevia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_vistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_vistaPrevia.Location = new System.Drawing.Point(733, 66);
            this.panel_vistaPrevia.Name = "panel_vistaPrevia";
            this.panel_vistaPrevia.Size = new System.Drawing.Size(234, 229);
            this.panel_vistaPrevia.TabIndex = 28;
            // 
            // abrir_cámara
            // 
            this.abrir_cámara.BackColor = System.Drawing.Color.DodgerBlue;
            this.abrir_cámara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir_cámara.Location = new System.Drawing.Point(787, 12);
            this.abrir_cámara.Name = "abrir_cámara";
            this.abrir_cámara.Size = new System.Drawing.Size(121, 39);
            this.abrir_cámara.TabIndex = 29;
            this.abrir_cámara.Text = "Abrir cámara";
            this.abrir_cámara.UseVisualStyleBackColor = false;
            this.abrir_cámara.Click += new System.EventHandler(this.Abrir_Cámara_Click);
            // 
            // capturar
            // 
            this.capturar.BackColor = System.Drawing.Color.DodgerBlue;
            this.capturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capturar.Location = new System.Drawing.Point(787, 12);
            this.capturar.Name = "capturar";
            this.capturar.Size = new System.Drawing.Size(130, 39);
            this.capturar.TabIndex = 30;
            this.capturar.Text = "Capturar foto";
            this.capturar.UseVisualStyleBackColor = false;
            this.capturar.Visible = false;
            this.capturar.Click += new System.EventHandler(this.capturar_Click);
            // 
            // Gestionar_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1320, 558);
            this.Controls.Add(this.capturar);
            this.Controls.Add(this.abrir_cámara);
            this.Controls.Add(this.panel_vistaPrevia);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.label_buscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel_botones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestionar_Persona";
            this.Text = "Gestionar Persona";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gestionar_Persona_Load);
            this.Shown += new System.EventHandler(this.menu_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_botones.ResumeLayout(false);
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_campos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Button vaciar;
        private System.Windows.Forms.Panel panel_vistaPrevia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha_pago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button guardar_cambios;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Button abrir_cámara;
        private System.Windows.Forms.Button capturar;
    }
}