using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ',' && !txtValor.Text.Contains(",")) return;
            e.Handled= true;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public int Quantity { get; set; }
        public decimal Valor { get; set; }

    }
}
