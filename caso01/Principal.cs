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
        int row;
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
            else
            {


                Array.Sort(array1);
                Array.Reverse(array1);

                double ultimo = array1[4];

                double[] array2 = { 0 };

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


                dataGridView2.Rows.Add(num, nombres, curso, nota1, nota2, nota3, nota4, nota5, totaldiv, ultimo, a);
                num = num + 1;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

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
            row = dataGridView2.CurrentRow.Index;
            textBox8.Text = dataGridView2[1, row].Value.ToString();
            textBox6.Text = dataGridView2[2, row].Value.ToString();
            textBox1.Text = dataGridView2[3, row].Value.ToString();
            textBox2.Text = dataGridView2[4, row].Value.ToString();
            textBox3.Text = dataGridView2[5, row].Value.ToString();
            textBox4.Text = dataGridView2[6, row].Value.ToString();
            textBox5.Text = dataGridView2[7, row].Value.ToString();
            textBox7.Text = dataGridView2[8, row].Value.ToString();



        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            dataGridView2.Rows.RemoveAt(row);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2[1, row].Value = textBox8.Text;
            dataGridView2[2, row].Value = textBox6.Text;
            dataGridView2[3, row].Value = textBox1.Text;
            dataGridView2[4, row].Value = textBox2.Text;
            dataGridView2[5, row].Value = textBox3.Text;
            dataGridView2[6, row].Value = textBox4.Text;
           


            string nombres, curso, promedio;
            nombres = textBox8.Text;
            curso = textBox6.Text;
        


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
            else
            {


                Array.Sort(array1);
                Array.Reverse(array1);

                double ultimo = array1[4];

                double[] array2 = { 0 };

                array2 = array1.Take(array1.Length - 1).ToArray();

                totalsum = array2.Sum();

                totaldiv = totalsum / 4;


                String a;

                if (totaldiv > 11)
                {
                    a = ("APROBADO");
                }
                else
                {
                    a = ("DESAPROBADO");
                }




                



                 dataGridView2[10, row].Value = a;
                dataGridView2[8, row].Value = totaldiv;


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();





            }
        }
    }
}


/*
    ELABORAR UN PROYECTO QUE PERMITA A REALIZAR LOS SIGUIENTES PROCESOS:
    
    ACCESO A LOS USUARIOS( CREDENCIALES )
        *EL PROYECTO DEBERÁ CONTROLAR EL ACCESO A TRES USUARIOS
        

        
    
    CONTROL DE LOS SIGUENTES PROCESOS:
        *CONTROL DE PEDIDOS POR CONSUMO DE CLIENTE
        *CONTROL DE REPARTO POR DELIBERY
        *CONTROL DE RESERVACIONES
        *
    (CADA USUARIO Y CONTRASEÑA DEL PERSONAL SE CREARA EN BASE A SUS DATOS PERSONALES)
       
    CADA PEDIDO (EN MESA, DELIVERY O RESERVACIÓN ) , DEVERÁ SER REGISTRADO EN EL DGV.

    SIMULANDO EL MANEJO DE UN CRUD
    
 
 */