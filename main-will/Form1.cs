using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace main_will
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1 = Convert.ToInt32(Interaction.InputBox("ingrese el primer numero"));
            num2 = Convert.ToInt32(Interaction.InputBox("ingrese el segundo numero"));

            suma = num1 + num2;
            MessageBox.Show("el resultado es: " + suma);
        }
    }
}
