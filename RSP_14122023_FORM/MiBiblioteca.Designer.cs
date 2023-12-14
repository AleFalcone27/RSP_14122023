namespace WinFormsApp1
{
    partial class MiBiblioteca
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
            listLibros = new ListBox();
            richTextBox1 = new RichTextBox();
            btn_Ingresar = new Button();
            btn_darDeBaja = new Button();
            btn_Listar = new Button();
            pb_ImagenBiblioteca = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_ImagenBiblioteca).BeginInit();
            SuspendLayout();
            // 
            // listLibros
            // 
            listLibros.FormattingEnabled = true;
            listLibros.ItemHeight = 15;
            listLibros.Location = new Point(2, 3);
            listLibros.Name = "listLibros";
            listLibros.Size = new Size(348, 439);
            listLibros.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(356, 283);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(440, 159);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(356, 208);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(133, 69);
            btn_Ingresar.TabIndex = 2;
            btn_Ingresar.Text = "Ingresar Libro";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += this.btn_Ingresar_Click;
            // 
            // btn_darDeBaja
            // 
            btn_darDeBaja.Location = new Point(506, 208);
            btn_darDeBaja.Name = "btn_darDeBaja";
            btn_darDeBaja.Size = new Size(133, 69);
            btn_darDeBaja.TabIndex = 3;
            btn_darDeBaja.Text = "Dar de baja libro seleccionado";
            btn_darDeBaja.UseVisualStyleBackColor = true;
            // 
            // btn_Listar
            // 
            btn_Listar.Location = new Point(655, 208);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(133, 69);
            btn_Listar.TabIndex = 4;
            btn_Listar.Text = "Listar Biblioteca";
            btn_Listar.UseVisualStyleBackColor = true;
            // 
            // pb_ImagenBiblioteca
            // 
            pb_ImagenBiblioteca.Image = Properties.Resources.ImgBiblioteca;
            pb_ImagenBiblioteca.Location = new Point(428, 22);
            pb_ImagenBiblioteca.Name = "pb_ImagenBiblioteca";
            pb_ImagenBiblioteca.Size = new Size(273, 166);
            pb_ImagenBiblioteca.TabIndex = 5;
            pb_ImagenBiblioteca.TabStop = false;
            // 
            // MiBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_ImagenBiblioteca);
            Controls.Add(btn_Listar);
            Controls.Add(btn_darDeBaja);
            Controls.Add(btn_Ingresar);
            Controls.Add(richTextBox1);
            Controls.Add(listLibros);
            Name = "MiBiblioteca";
            Text = "MiBiblioteca";
            ((System.ComponentModel.ISupportInitialize)pb_ImagenBiblioteca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listLibros;
        private RichTextBox richTextBox1;
        private Button btn_Ingresar;
        private Button btn_darDeBaja;
        private Button btn_Listar;
        private PictureBox pb_ImagenBiblioteca;
    }
}
