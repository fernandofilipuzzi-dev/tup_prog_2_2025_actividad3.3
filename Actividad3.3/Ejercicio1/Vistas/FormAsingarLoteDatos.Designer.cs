namespace Ejercicio1.Vistas
{
    partial class FormAsingarLoteDatos
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
            groupBox1 = new GroupBox();
            btnMostrarCampos = new Button();
            label3 = new Label();
            tbIdentificadorParcela = new TextBox();
            tbSuperficieParcela = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCampos = new ComboBox();
            btnAltaParcela = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 171);
            groupBox1.TabIndex = 8;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 12;
            label3.Text = "Identificador de parcela";
            // 
            // tbIdentificadorParcela
            // 
            tbIdentificadorParcela.Location = new Point(199, 95);
            tbIdentificadorParcela.Name = "tbIdentificadorParcela";
            tbIdentificadorParcela.Size = new Size(100, 25);
            tbIdentificadorParcela.TabIndex = 11;
            // 
            // tbSuperficieParcela
            // 
            tbSuperficieParcela.Location = new Point(199, 130);
            tbSuperficieParcela.Name = "tbSuperficieParcela";
            tbSuperficieParcela.Size = new Size(100, 25);
            tbSuperficieParcela.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 130);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 9;
            label2.Text = "Superficie parcela";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 8;
            label1.Text = "Elegir campo";
            // 
            // cmbCampos
            // 
            cmbCampos.FormattingEnabled = true;
            cmbCampos.Location = new Point(143, 34);
            cmbCampos.Name = "cmbCampos";
            cmbCampos.Size = new Size(156, 25);
            cmbCampos.TabIndex = 7;
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
            // 
            // FormAsingarLoteDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 212);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormAsingarLoteDatos";
            Text = "FormAsingarLoteDatos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMostrarCampos;
        private Label label3;
        private TextBox tbIdentificadorParcela;
        private TextBox tbSuperficieParcela;
        private Label label2;
        private Label label1;
        private ComboBox cmbCampos;
        private Button btnAltaParcela;
    }
}