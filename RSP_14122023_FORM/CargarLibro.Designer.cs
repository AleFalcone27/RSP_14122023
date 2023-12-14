namespace WinFormsApp1
{
    partial class CargarLibro
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            cb_edEspecial = new CheckBox();
            cb_aColor = new CheckBox();
            btn_Crear = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 45);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 20F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(5, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(241, 45);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(5, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre del libro";
            textBox1.Size = new Size(239, 43);
            textBox1.TabIndex = 2;
            // 
            // cb_edEspecial
            // 
            cb_edEspecial.AutoSize = true;
            cb_edEspecial.Location = new Point(12, 168);
            cb_edEspecial.Name = "cb_edEspecial";
            cb_edEspecial.Size = new Size(129, 19);
            cb_edEspecial.TabIndex = 3;
            cb_edEspecial.Text = "Es edición especial?";
            cb_edEspecial.UseVisualStyleBackColor = true;
            // 
            // cb_aColor
            // 
            cb_aColor.AutoSize = true;
            cb_aColor.Location = new Point(12, 193);
            cb_aColor.Name = "cb_aColor";
            cb_aColor.Size = new Size(69, 19);
            cb_aColor.TabIndex = 4;
            cb_aColor.Text = "A color?";
            cb_aColor.UseVisualStyleBackColor = true;
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(5, 218);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(241, 31);
            btn_Crear.TabIndex = 5;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            // 
            // CargarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 258);
            Controls.Add(btn_Crear);
            Controls.Add(cb_aColor);
            Controls.Add(cb_edEspecial);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "CargarLibro";
            Text = "CargarLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private CheckBox cb_edEspecial;
        private CheckBox cb_aColor;
        private Button btn_Crear;
    }
}