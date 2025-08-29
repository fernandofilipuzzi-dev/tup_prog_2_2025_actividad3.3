namespace Ejercicio1
{
    partial class Form1
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
            listBox1 = new ListBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(22, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(149, 157);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(123, 24);
            button1.Name = "button1";
            button1.Size = new Size(79, 60);
            button1.TabIndex = 1;
            button1.Text = "Crear Figura";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 21);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ortoedro";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(22, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 21);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cilindro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 107);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Location = new Point(177, 134);
            button2.Name = "button2";
            button2.Size = new Size(75, 60);
            button2.TabIndex = 4;
            button2.Text = "Actualizar Listado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(177, 214);
            button3.Name = "button3";
            button3.Size = new Size(75, 60);
            button3.TabIndex = 5;
            button3.Text = "Mostrar mas datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(268, 214);
            label1.Name = "label1";
            label1.Size = new Size(119, 77);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // button4
            // 
            button4.Location = new Point(297, 48);
            button4.Name = "button4";
            button4.Size = new Size(79, 60);
            button4.TabIndex = 7;
            button4.Text = "Crear Figura";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 326);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}
