using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado = numero2 + numero1;
            MessageBox.Show($"A soma do {numero1} + {numero2} é igual a {resultado}");

        }
    }
}
