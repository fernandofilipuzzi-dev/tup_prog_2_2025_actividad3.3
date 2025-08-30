namespace Ejercicio1.Vistas
{
    partial class FormDatosParcela
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
            groupBox4 = new GroupBox();
            cmbParcelasDisponibles = new ComboBox();
            label12 = new Label();
            cmbCamposDisponibles = new ComboBox();
            btnCamposDisponibles = new Button();
            label11 = new Label();
            btnAsignarParcela = new Button();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbParcelasDisponibles);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmbCamposDisponibles);
            groupBox4.Controls.Add(btnCamposDisponibles);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnAsignarParcela);
            groupBox4.Location = new Point(25, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(505, 193);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Alta de parcela  en Actividad(5)";
            // 
            // cmbParcelasDisponibles
            // 
            cmbParcelasDisponibles.FormattingEnabled = true;
            cmbParcelasDisponibles.Location = new Point(165, 111);
            cmbParcelasDisponibles.Name = "cmbParcelasDisponibles";
            cmbParcelasDisponibles.Size = new Size(140, 25);
            cmbParcelasDisponibles.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 40);
            label12.Name = "label12";
            label12.Size = new Size(85, 17);
            label12.TabIndex = 19;
            label12.Text = "Elegir campo";
            // 
            // cmbCamposDisponibles
            // 
            cmbCamposDisponibles.FormattingEnabled = true;
            cmbCamposDisponibles.Location = new Point(165, 37);
            cmbCamposDisponibles.Name = "cmbCamposDisponibles";
            cmbCamposDisponibles.Size = new Size(140, 25);
            cmbCamposDisponibles.TabIndex = 18;
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
            // 
            // FormDatosActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 216);
            Controls.Add(groupBox4);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDatosActividad";
            Text = "FormDatosParcela";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private ComboBox cmbParcelasDisponibles;
        private Label label12;
        private ComboBox cmbCamposDisponibles;
        private Button btnCamposDisponibles;
        private Label label11;
        private Button btnAsignarParcela;
    }
}