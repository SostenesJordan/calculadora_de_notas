using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculadora_de_notas
{
    public partial class Form1 : Form
    {
        double v1, v2, v3;
        double nota;


        public Form1()
        {
            InitializeComponent();
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {
            

            v1 = Convert.ToDouble(n1.Text);

            
        }
       
        private void n2_TextChanged(object sender, EventArgs e)
        {
            v2 = Convert.ToDouble(n2.Text);

        }

        private void n3_TextChanged(object sender, EventArgs e)
        {
            
            v3 = Convert.ToDouble(n3.Text);
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            nota = (v1 + v2 + v3) / 3;

            if (nota >= 6)
            {
                MessageBox.Show("APROVADO! "+
                "\nsua nota :" + nota);

            }
            else
            {
                MessageBox.Show("REPROVADO!"
                +"\nsua nota :" + nota);

            }

           


        }
    }
}
