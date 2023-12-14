namespace WinFormsApp1
{
    public partial class MiBiblioteca : Form
    {
        public MiBiblioteca()
        {
            InitializeComponent();

        }


        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            CargarLibro cargar = new CargarLibro();
            cargar.ShowDialog();
        }

    }
}
