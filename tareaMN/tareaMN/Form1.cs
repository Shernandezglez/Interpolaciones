using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaMN
{
    public partial class Form1 : Form
    {
        TextBox[] ss;
        TextBox[] temp;
        double sum = 0;
        double fn = 0;
        double r = 0;

        public Form1()
        {
            InitializeComponent();
            
        }
        

        public void CreateFields(double a, double b, double n)
        {
            double incremento = (b - a) / n;
            int y = 10;

            
            ss = new TextBox[Convert.ToInt32(n) + 1];
            
            
            for (int i = 0; a <= b; a += incremento)
            {
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Location = new System.Drawing.Point(20, y);
                lbl.Text = Convert.ToString(Math.Round(a, 4));

                var txt = new TextBox();
                ss[i] = txt;
                txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt.Location = new System.Drawing.Point(lbl.Width, y);
                txt.Width = panel1.Width - txt.Location.X - 300;

                panel1.Controls.Add(txt);
                panel1.Controls.Add(lbl);

                y += 60;
                
                
            }
            panel1.PerformLayout();

            
        }
       
        
        public void calcularTrapecio()
        {

            for(int i = 0; i < ss.Length; i++)
            {
                ss[i].Text = "aa";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFields(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtN.Text));
            
        }

        private void btnCalcTrapecio_Click(object sender, EventArgs e)
        {
            calcularTrapecio();
        }
    }
}
