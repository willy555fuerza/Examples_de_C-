namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Usuario = "Willy";
        string Contraseņa = "1234567";


        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            if (user.Equals(Usuario))
            {
                if (password.Equals(Contraseņa))
                {
                    MessageBox.Show("Login Exitoso");
                }
                else
                {
                    MessageBox.Show("Contraseņa incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario no es correcto");
            }
        }
    }
}