using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caso01
{
    public partial class Principal : Form

    
    {
        int num = 1;
        public Principal()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombres, curso, promedio;
            nombres = textBox8.Text;
            curso = textBox6.Text;
            promedio = textBox7.Text;


            double nota1, nota2, nota3, nota4, nota5, totalsum, totaldiv;


            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);
            nota3 = double.Parse(textBox3.Text);
            nota4 = double.Parse(textBox4.Text);
            nota5 = double.Parse(textBox5.Text);

            double[] array1 = { nota1, nota2, nota3, nota4, nota5 };
 

            if (nota1 > 20 || nota2 > 20 || nota3 > 20 || nota4 > 20 || nota5 > 20)
            {
                MessageBox.Show("Solo ingrese numeros del 1 al 20");

            }
            else {


                Array.Sort(array1);
                Array.Reverse(array1);

                double ultimo = array1[4];

                double [] array2 = {0};

                array2 = array1.Take(array1.Length - 1).ToArray();
                
                totalsum = array2.Sum();

                totaldiv = totalsum / 4;

                
                textBox7.Text += totaldiv;
                String a;

                if (totaldiv > 11)
                {
                    a = ("APROBADO");
                }
                else
                {
                    a = ("DESAPROBADO");
                }

                textBox9.Text += a;

                dataGridView2.Rows.Add(num, nombres, curso, nota1, nota2, nota3, nota4, nota5, totaldiv,ultimo);
                num = num + 1;
            }
          

        
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
