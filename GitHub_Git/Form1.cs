using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Git
{
    public partial class Form1 : Form
    {
        public struct Utilizador
        {
            public string nome;
            public string senha;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Show();

            this.Hide();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
