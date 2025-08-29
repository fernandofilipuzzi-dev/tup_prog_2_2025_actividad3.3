namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearEstancia = new Button();
            btnAltaParcela = new Button();
            groupBox1 = new GroupBox();
            btnMostrarCampos = new Button();
            label3 = new Label();
            tbIdentificadorParcela = new TextBox();
            tbSuperficieParcela = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCampos = new ComboBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            tbIdentificadorCampo = new TextBox();
            tbSuperficieCampo = new TextBox();
            label5 = new Label();
            btnAltaCampo = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbPeriodoActividad = new TextBox();
            tbDescripcionActividad = new TextBox();
            label8 = new Label();
            label6 = new Label();
            cmbTipoActividad = new ComboBox();
            btnAltaActividad = new Button();
            groupBox4 = new GroupBox();
            label12 = new Label();
            cmbCamposDisponibles = new ComboBox();
            btnCamposDisponibles = new Button();
            label11 = new Label();
            btnAsignarParcela = new Button();
            cmbParcelasDisponibles = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearEstancia
            // 
            btnCrearEstancia.Location = new Point(13, 13);
            btnCrearEstancia.Margin = new Padding(4);
            btnCrearEstancia.Name = "btnCrearEstancia";
            btnCrearEstancia.Size = new Size(167, 66);
            btnCrearEstancia.TabIndex = 4;
            btnCrearEstancia.Text = "Crear Estancia(1)";
            btnCrearEstancia.UseVisualStyleBackColor = true;
            btnCrearEstancia.Click += btnCrearEstancia_Click;
            // 
            // btnAltaParcela
            // 
            btnAltaParcela.Location = new Point(320, 95);
            btnAltaParcela.Margin = new Padding(4);
            btnAltaParcela.Name = "btnAltaParcela";
            btnAltaParcela.Size = new Size(167, 64);
            btnAltaParcela.TabIndex = 6;
            btnAltaParcela.Text = "Alta de  Parcela (c)";
            btnAltaParcela.UseVisualStyleBackColor = true;
            btnAltaParcela.Click += btnAltaParcela_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrarCampos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbIdentificadorParcela);
            groupBox1.Controls.Add(tbSuperficieParcela);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCampos);
            groupBox1.Controls.Add(btnAltaParcela);
            groupBox1.Location = new Point(13, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 171);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta de lotesAsignados(3)";
            // 
            // btnMostrarCampos
            // 
            btnMostrarCampos.Location = new Point(320, 30);
            btnMostrarCampos.Margin = new Padding(4);
            btnMostrarCampos.Name = "btnMostrarCampos";
            btnMostrarCampos.Size = new Size(167, 57);
            btnMostrarCampos.TabIndex = 13;
            btnMostrarCampos.Text = "Actualizar listado de campos (a)";
            btnMostrarCampos.UseVisualStyleBackColor = true;
            btnMostrarCampos.Click += btnMostrarCampos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(172, 21);
            label3.TabIndex = 12;
            label3.Text = "Identificador de parcela";
            // 
            // tbIdentificadorParcela
            // 
            tbIdentificadorParcela.Location = new Point(199, 95);
            tbIdentificadorParcela.Name = "tbIdentificadorParcela";
            tbIdentificadorParcela.Size = new Size(100, 29);
            tbIdentificadorParcela.TabIndex = 11;
            // 
            // tbSuperficieParcela
            // 
            tbSuperficieParcela.Location = new Point(199, 130);
            tbSuperficieParcela.Name = "tbSuperficieParcela";
            tbSuperficieParcela.Size = new Size(100, 29);
            tbSuperficieParcela.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 130);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 9;
            label2.Text = "Superficie parcela";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 8;
            label1.Text = "Elegir campo";
            // 
            // cmbCampos
            // 
            cmbCampos.FormattingEnabled = true;
            cmbCampos.Location = new Point(143, 34);
            cmbCampos.Name = "cmbCampos";
            cmbCampos.Size = new Size(156, 29);
            cmbCampos.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbIdentificadorCampo);
            groupBox2.Controls.Add(tbSuperficieCampo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAltaCampo);
            groupBox2.Location = new Point(13, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 113);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alta de campos (2)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 40);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 12;
            label4.Text = "Identificador";
            // 
            // tbIdentificadorCampo
            // 
            tbIdentificadorCampo.Location = new Point(202, 37);
            tbIdentificadorCampo.Name = "tbIdentificadorCampo";
            tbIdentificadorCampo.Size = new Size(100, 29);
            tbIdentificadorCampo.TabIndex = 11;
            // 
            // tbSuperficieCampo
            // 
            tbSuperficieCampo.Location = new Point(202, 72);
            tbSuperficieCampo.Name = "tbSuperficieCampo";
            tbSuperficieCampo.Size = new Size(100, 29);
            tbSuperficieCampo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 75);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 9;
            label5.Text = "Superficie";
            // 
            // btnAltaCampo
            // 
            btnAltaCampo.Location = new Point(320, 34);
            btnAltaCampo.Margin = new Padding(4);
            btnAltaCampo.Name = "btnAltaCampo";
            btnAltaCampo.Size = new Size(167, 66);
            btnAltaCampo.TabIndex = 6;
            btnAltaCampo.Text = "Alta de campo";
            btnAltaCampo.UseVisualStyleBackColor = true;
            btnAltaCampo.Click += btnAltaCampo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbPeriodoActividad);
            groupBox3.Controls.Add(tbDescripcionActividad);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmbTipoActividad);
            groupBox3.Controls.Add(btnAltaActividad);
            groupBox3.Location = new Point(12, 382);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 160);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alta de actividad (4)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 87);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 16;
            label7.Text = "Periodo";
            // 
            // tbPeriodoActividad
            // 
            tbPeriodoActividad.Location = new Point(200, 84);
            tbPeriodoActividad.Name = "tbPeriodoActividad";
            tbPeriodoActividad.Size = new Size(100, 29);
            tbPeriodoActividad.TabIndex = 15;
            // 
            // tbDescripcionActividad
            // 
            tbDescripcionActividad.Location = new Point(200, 119);
            tbDescripcionActividad.Name = "tbDescripcionActividad";
            tbDescripcionActividad.Size = new Size(100, 29);
            tbDescripcionActividad.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 122);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 13;
            label8.Text = "Descripcion";
            // 
            // label6
            // 
            label6.Location = new Point(25, 40);
            label6.Name = "label6";
            label6.Size = new Size(100, 53);
            label6.TabIndex = 9;
            label6.Text = "Elegir tipo de Actividad";
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Location = new Point(144, 46);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(156, 29);
            cmbTipoActividad.TabIndex = 8;
            // 
            // btnAltaActividad
            // 
            btnAltaActividad.Location = new Point(321, 84);
            btnAltaActividad.Margin = new Padding(4);
            btnAltaActividad.Name = "btnAltaActividad";
            btnAltaActividad.Size = new Size(167, 66);
            btnAltaActividad.TabIndex = 6;
            btnAltaActividad.Text = "Alta de Actividad";
            btnAltaActividad.UseVisualStyleBackColor = true;
            btnAltaActividad.Click += btnAltaActividad_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbParcelasDisponibles);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmbCamposDisponibles);
            groupBox4.Controls.Add(btnCamposDisponibles);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnAsignarParcela);
            groupBox4.Location = new Point(544, 39);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(505, 193);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Alta de parcela  en Actividad(5)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 40);
            label12.Name = "label12";
            label12.Size = new Size(100, 21);
            label12.TabIndex = 19;
            label12.Text = "Elegir campo";
            // 
            // cmbCamposDisponibles
            // 
            cmbCamposDisponibles.FormattingEnabled = true;
            cmbCamposDisponibles.Location = new Point(165, 37);
            cmbCamposDisponibles.Name = "cmbCamposDisponibles";
            cmbCamposDisponibles.Size = new Size(140, 29);
            cmbCamposDisponibles.TabIndex = 18;
            cmbCamposDisponibles.SelectedIndexChanged += cmbCamposDisponibles_SelectedIndexChanged;
            // 
            // btnCamposDisponibles
            // 
            btnCamposDisponibles.Location = new Point(322, 29);
            btnCamposDisponibles.Margin = new Padding(4);
            btnCamposDisponibles.Name = "btnCamposDisponibles";
            btnCamposDisponibles.Size = new Size(167, 61);
            btnCamposDisponibles.TabIndex = 17;
            btnCamposDisponibles.Text = "Actualizar campos disponibles";
            btnCamposDisponibles.UseVisualStyleBackColor = true;
            btnCamposDisponibles.Click += btnCamposDisponibles_Click;
            // 
            // label11
            // 
            label11.Location = new Point(15, 114);
            label11.Name = "label11";
            label11.Size = new Size(144, 53);
            label11.TabIndex = 9;
            label11.Text = "Elegir las parcelas disponibles";
            // 
            // btnAsignarParcela
            // 
            btnAsignarParcela.Location = new Point(322, 114);
            btnAsignarParcela.Margin = new Padding(4);
            btnAsignarParcela.Name = "btnAsignarParcela";
            btnAsignarParcela.Size = new Size(167, 66);
            btnAsignarParcela.TabIndex = 6;
            btnAsignarParcela.Text = "Asignar Parcela";
            btnAsignarParcela.UseVisualStyleBackColor = true;
            btnAsignarParcela.Click += btnAsignarParcela_Click;
            // 
            // cmbParcelasDisponibles
            // 
            cmbParcelasDisponibles.FormattingEnabled = true;
            cmbParcelasDisponibles.Location = new Point(165, 111);
            cmbParcelasDisponibles.Name = "cmbParcelasDisponibles";
            cmbParcelasDisponibles.Size = new Size(140, 29);
            cmbParcelasDisponibles.TabIndex = 20;
            cmbParcelasDisponibles.SelectedIndexChanged += cmbParcelasDisponibles_SelectedIndexChanged;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 551);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCrearEstancia);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCrearEstancia;
        private Button btnAltaParcela;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cmbCampos;
        private Label label3;
        private TextBox tbIdentificadorParcela;
        private TextBox tbSuperficieParcela;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox tbIdentificadorCampo;
        private TextBox tbSuperficieCampo;
        private Label label5;
        private Button btnAltaCampo;
        private Button btnMostrarCampos;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox cmbTipoActividad;
        private Button btnAltaActividad;
        private Label label7;
        private TextBox tbPeriodoActividad;
        private TextBox tbDescripcionActividad;
        private Label label8;
        private GroupBox groupBox4;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private Button btnAsignarParcela;
        private Label label12;
        private ComboBox cmbCamposDisponibles;
        private Button btnCamposDisponibles;
        private ComboBox cmbParcelasDisponibles;
    }
}
