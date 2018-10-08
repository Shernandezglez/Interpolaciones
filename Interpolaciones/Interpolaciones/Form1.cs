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

            try
            {
                if ((string)Operaciones.SelectedItem != "Lagrange" && primer.Checked && segundo.Checked)
                {
                    MessageBox.Show("No puedes usar ningun orden si no seleccionas el metodo de lagrange");
                }

                else
                {
                    if ((string)Operaciones.SelectedItem == "Inter(Normal)")
                    {
                        inter.calcularInter(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtX0.Text), Convert.ToInt32(txtX1.Text));

                        txtResultado.Text = inter.resultado();
                    }
                    else if ((string)Operaciones.SelectedItem == "Lagrange")
                    {
                        if (primer.Checked && segundo.Checked)
                        {
                            MessageBox.Show("solo puede elejir uno");
                        }
                        else
                        {
                            if (primer.Checked)
                            {
                                inter.lagrange1(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtX0.Text), Convert.ToInt32(txtX1.Text));
                                txtResultado.Text = inter.resultado();
                            }
                            else if (segundo.Checked)
                            {
                                inter.lagrange2(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtX0.Text), Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text));
                                txtResultado.Text = inter.resultado();
                            }
                            else
                            {
                                MessageBox.Show("Error, Selecciona un orden");
                            }
                        }

                    }
                    else if ((string)Operaciones.SelectedItem == "Cuadratica")
                    {

                        inter.InterCuadratica(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtX0.Text), Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text));
                        txtResultado.Text = inter.resultado();
                    }


                    else
                    {
                        MessageBox.Show("elija el método de interpolación");
                    }
                }
            }catch(FormatException)
            {
                MessageBox.Show("Solo se aceptan numeros");
            }


            txtX.Clear();
            txtX0.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtX.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
