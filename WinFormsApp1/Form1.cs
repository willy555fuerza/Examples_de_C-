namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Usuario = "Willy";
        string Contrase�a = "1234567";


        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            if (user.Equals(Usuario))
            {
                if (password.Equals(Contrase�a))
                {
                    MessageBox.Show("Login Exitoso");
                }
                else
                {
                    MessageBox.Show("Contrase�a incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario no es correcto");
            }
        }
    }
}