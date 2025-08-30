namespace Ejercicio1.Vistas
{
    partial class FormDatosActividad
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
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbPeriodoActividad = new TextBox();
            tbDescripcionActividad = new TextBox();
            label8 = new Label();
            label6 = new Label();
            cmbTipoActividad = new ComboBox();
            btnAltaActividad = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 160);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alta de actividad (4)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 87);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 16;
            label7.Text = "Periodo";
            // 
            // tbPeriodoActividad
            // 
            tbPeriodoActividad.Location = new Point(200, 84);
            tbPeriodoActividad.Name = "tbPeriodoActividad";
            tbPeriodoActividad.Size = new Size(100, 23);
            tbPeriodoActividad.TabIndex = 15;
            // 
            // tbDescripcionActividad
            // 
            tbDescripcionActividad.Location = new Point(200, 119);
            tbDescripcionActividad.Name = "tbDescripcionActividad";
            tbDescripcionActividad.Size = new Size(100, 23);
            tbDescripcionActividad.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 122);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
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
            cmbTipoActividad.Size = new Size(156, 23);
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
            // 
            // FormDatosActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 183);
            Controls.Add(groupBox3);
            Name = "FormDatosActividad";
            Text = "FormDatosActividad";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label7;
        private TextBox tbPeriodoActividad;
        private TextBox tbDescripcionActividad;
        private Label label8;
        private Label label6;
        private ComboBox cmbTipoActividad;
        private Button btnAltaActividad;
    }
}