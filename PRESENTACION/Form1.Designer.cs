namespace retoCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_dni = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Cmb_doc = new System.Windows.Forms.ComboBox();
            this.Cmb_grupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dgv_lista_clientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista_clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 100);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 17.82178F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(187, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(537, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "CRUD: EDICION DE DATOS CLIENTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_salir);
            this.panel2.Controls.Add(this.btn_reporte);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(737, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 737);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(51, 605);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 49);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(51, 533);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(107, 49);
            this.btn_reporte.TabIndex = 17;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(51, 466);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(107, 49);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(51, 401);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(107, 49);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(51, 344);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(107, 49);
            this.btn_nuevo.TabIndex = 14;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Txt_telefono);
            this.groupBox2.Controls.Add(this.Txt_dni);
            this.groupBox2.Controls.Add(this.Txt_direccion);
            this.groupBox2.Controls.Add(this.Txt_apellido);
            this.groupBox2.Controls.Add(this.Txt_nombre);
            this.groupBox2.Controls.Add(this.Cmb_doc);
            this.groupBox2.Controls.Add(this.Cmb_grupo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(192, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(6, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(399, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(447, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "*";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Enabled = false;
            this.Txt_telefono.Location = new System.Drawing.Point(514, 116);
            this.Txt_telefono.MaxLength = 9;
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(144, 26);
            this.Txt_telefono.TabIndex = 16;
            // 
            // Txt_dni
            // 
            this.Txt_dni.Enabled = false;
            this.Txt_dni.Location = new System.Drawing.Point(514, 35);
            this.Txt_dni.MaxLength = 8;
            this.Txt_dni.Name = "Txt_dni";
            this.Txt_dni.Size = new System.Drawing.Size(144, 26);
            this.Txt_dni.TabIndex = 15;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Enabled = false;
            this.Txt_direccion.Location = new System.Drawing.Point(133, 116);
            this.Txt_direccion.MaxLength = 50;
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(265, 26);
            this.Txt_direccion.TabIndex = 14;
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Enabled = false;
            this.Txt_apellido.Location = new System.Drawing.Point(133, 74);
            this.Txt_apellido.MaxLength = 50;
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(265, 26);
            this.Txt_apellido.TabIndex = 13;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Location = new System.Drawing.Point(133, 35);
            this.Txt_nombre.MaxLength = 50;
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(265, 26);
            this.Txt_nombre.TabIndex = 12;
            // 
            // Cmb_doc
            // 
            this.Cmb_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_doc.Enabled = false;
            this.Cmb_doc.Font = new System.Drawing.Font("Verdana", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_doc.FormattingEnabled = true;
            this.Cmb_doc.Location = new System.Drawing.Point(219, 191);
            this.Cmb_doc.Name = "Cmb_doc";
            this.Cmb_doc.Size = new System.Drawing.Size(439, 21);
            this.Cmb_doc.TabIndex = 8;
            // 
            // Cmb_grupo
            // 
            this.Cmb_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_grupo.Enabled = false;
            this.Cmb_grupo.Font = new System.Drawing.Font("Verdana", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_grupo.FormattingEnabled = true;
            this.Cmb_grupo.Location = new System.Drawing.Point(26, 191);
            this.Cmb_grupo.Name = "Cmb_grupo";
            this.Cmb_grupo.Size = new System.Drawing.Size(139, 21);
            this.Cmb_grupo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "TIPO DE DOCUMENTO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "GRUPO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIRECCION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.Dgv_lista_clientes);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 516);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Dgv_lista_clientes
            // 
            this.Dgv_lista_clientes.AllowUserToAddRows = false;
            this.Dgv_lista_clientes.AllowUserToDeleteRows = false;
            this.Dgv_lista_clientes.AllowUserToOrderColumns = true;
            this.Dgv_lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_lista_clientes.Location = new System.Drawing.Point(22, 38);
            this.Dgv_lista_clientes.Name = "Dgv_lista_clientes";
            this.Dgv_lista_clientes.ReadOnly = true;
            this.Dgv_lista_clientes.RowHeadersWidth = 43;
            this.Dgv_lista_clientes.Size = new System.Drawing.Size(636, 150);
            this.Dgv_lista_clientes.TabIndex = 0;
            this.Dgv_lista_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_lista_clientes_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.Txt_buscar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(561, 59);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 39);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(119, 66);
            this.Txt_buscar.MaxLength = 50;
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(398, 26);
            this.Txt_buscar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Por nombre o apellido:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(237, 753);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 39);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(413, 753);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 39);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 837);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista_clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_doc;
        private System.Windows.Forms.ComboBox Cmb_grupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_dni;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.DataGridView Dgv_lista_clientes;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

