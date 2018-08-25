using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Interpolacion inter = new Interpolacion();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            inter.calcularInter(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtX0.Text), Convert.ToInt32(txtX1.Text));

            txtResultado.Text = inter.resultado();

        }
    }
}
