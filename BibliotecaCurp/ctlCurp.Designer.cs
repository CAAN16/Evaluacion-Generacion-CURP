﻿namespace BibliotecaCurp
{
    partial class ctlCurp
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            txtSegundoApellido = new TextBox();
            dtpFechaNac = new DateTimePicker();
            label5 = new Label();
            cboSexo = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cboEstado = new ComboBox();
            label8 = new Label();
            lblCurpGenerada = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(566, 31);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la App de para Generación de CURP";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(21, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej Carlos";
            txtNombre.Size = new Size(234, 30);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(21, 165);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.Location = new Point(21, 192);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.PlaceholderText = "Ej Abrego";
            txtPrimerApellido.Size = new Size(234, 30);
            txtPrimerApellido.TabIndex = 6;
            txtPrimerApellido.TextChanged += txtPrimerApellido_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(21, 260);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 9;
            label4.Text = "Apellido Materno:";
            label4.Click += label4_Click;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.Location = new Point(21, 287);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.PlaceholderText = "Ej Nuñez";
            txtSegundoApellido.Size = new Size(234, 30);
            txtSegundoApellido.TabIndex = 8;
            txtSegundoApellido.TextChanged += txtSegundoApellido_TextChanged;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(291, 291);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(234, 30);
            dtpFechaNac.TabIndex = 10;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(291, 265);
            label5.Name = "label5";
            label5.Size = new Size(182, 23);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboSexo.Location = new Point(291, 104);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(234, 31);
            cboSexo.TabIndex = 12;
            cboSexo.SelectedIndexChanged += cboSexo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(291, 79);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 13;
            label6.Text = "Sexo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(291, 167);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 15;
            label7.Text = "Entidad Federativa:";
            // 
            // cboEstado
            // 
            cboEstado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(291, 192);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(234, 31);
            cboEstado.TabIndex = 14;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(603, 145);
            label8.Name = "label8";
            label8.Size = new Size(197, 31);
            label8.TabIndex = 16;
            label8.Text = "CURP Generada:";
            // 
            // lblCurpGenerada
            // 
            lblCurpGenerada.AutoSize = true;
            lblCurpGenerada.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurpGenerada.ForeColor = Color.FromArgb(0, 0, 192);
            lblCurpGenerada.Location = new Point(563, 196);
            lblCurpGenerada.Name = "lblCurpGenerada";
            lblCurpGenerada.Size = new Size(284, 31);
            lblCurpGenerada.TabIndex = 17;
            lblCurpGenerada.Text = "AENC050621HGTBXRA1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(624, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // ctlCurp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblCurpGenerada);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cboEstado);
            Controls.Add(label6);
            Controls.Add(cboSexo);
            Controls.Add(label5);
            Controls.Add(dtpFechaNac);
            Controls.Add(label4);
            Controls.Add(txtSegundoApellido);
            Controls.Add(label3);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "ctlCurp";
            Size = new Size(874, 357);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtPrimerApellido;
        private Label label4;
        private TextBox txtSegundoApellido;
        private DateTimePicker dtpFechaNac;
        private Label label5;
        private ComboBox cboSexo;
        private Label label6;
        private Label label7;
        private ComboBox cboEstado;
        private Label label8;
        private Label lblCurpGenerada;
        private PictureBox pictureBox1;
    }
}
