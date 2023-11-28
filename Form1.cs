using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PreguntaDadosVG
{
    public partial class PreguntasDadosVI : Form
    {
        public PreguntasDadosVI()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "P"; // Utilizar el formato de porcentaje
            dataGridView1.Columns["Column2"].DefaultCellStyle = style;
            definirBox.Checked = true;

            Bitmap imagen = new Bitmap(@"D:\Proyectos\PreguntaDadosVG\Resources\dado_6.png");

            // Set the image to the PictureBox
            cuadroResultado.Image = imagen;

        }


        static double ProbTodos(int tamDado, int tiro)
        {
            int X = tamDado; // Puedes cambiar esto al número deseado de lanzamientos

            float probabilidad = 0f;

            int probInt = 0;

            float tamDadod = (float)tamDado;
            probabilidad = (float)CalcularProbabilidad(tiro, tamDado);
            probInt = (int)probabilidad * 100;
            return probabilidad;

        }
        static double ProbLanza(int tamDado, int tiro)
        {
            float[] matriz = new float[tamDado];
            float tamDadod = (float)tamDado;
            float probabilidad = 0f;
            int probInt = 0;
            probabilidad = (float)((1.0 / tamDadod) * Math.Pow((tamDadod - 1) / tamDadod, tiro - 1));
            probInt = (int)probabilidad * 100;
            return probabilidad;
        }

        static double ProbAnt(int tamDado, int tiro)
        {
            float[] matriz = new float[tamDado];
            float tamDadod = (float)tamDado;
            float probabilidad = 0f;
            int probInt = 0;
            probabilidad = (float)(1 - Math.Pow((tamDadod - 1) / tamDadod, tiro));
            probInt = (int)probabilidad * 100;
            return probabilidad;
        }

        static double CalcularProbabilidad(int X, int tamDadox)
        {
            double resultado = 0;
            for (int i = 0; i <= tamDadox; i++)
            {
                resultado += Math.Pow(-1, i) * Binomial(tamDadox, i) * Math.Pow((tamDadox - i) / Convert.ToDouble(tamDadox), X);
            }

            return resultado;
        }

        static int Binomial(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }

            return Binomial(n - 1, k - 1) + Binomial(n - 1, k);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opcionesBox.SelectedItem != null)
            {
                txtSalida.Text = opcionesBox.SelectedItem.ToString();
                int dadoInt = (int)tamDadoBox.Value;
                int tiro = (int)numTiros.Value;

                double resultado = 0;

                if (definirBox.Checked == false)
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 1; i < tiro*5; i++)
                    {
                        switch (txtSalida.Text)
                        {
                            case "de obtener todas las opciones":
                                resultado = ProbTodos(dadoInt, i);
                                break;
                            case "de obtener una opción":
                                resultado = ProbLanza(dadoInt, i);
                                break;
                            case "de obtener una opción antes del lanzamiento dado":
                                resultado = ProbAnt(dadoInt, i);
                                break;
                            case "de no obtener el resultado deseado":
                                resultado = 1.0 - ProbTodos(dadoInt, i);
                                break;
                            case "de no obtener la opción en el tiro dado":
                                resultado = 1.0 - ProbLanza(dadoInt, i);
                                break;
                        }
                        dataGridView1.Rows.Add(i, resultado);
                    }

                    txtSalida.Text = string.Empty;

                }

                else
                {
                    switch (txtSalida.Text)
                    {
                        case "de obtener todas las opciones":
                            resultado = ProbTodos(dadoInt, tiro);
                            break;
                        case "de obtener una opción":
                            resultado = ProbLanza(dadoInt, tiro);
                            break;
                        case "de obtener una opción antes del lanzamiento dado":
                            resultado = ProbAnt(dadoInt, tiro);
                            break;
                        case "de no obtener el resultado deseado":
                            resultado = 1.0 - ProbTodos(dadoInt, tiro);
                            break;
                        case "de no obtener la opción en el tiro dado":
                            resultado = 1.0 - ProbLanza(dadoInt, tiro);
                            break;
                    }

                    txtSalida.Text = Convert.ToString(resultado);
                }


            }
            else
            {
                opcionesBox.DroppedDown = true;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSalida.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        private void textoSalida_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numTiros.Enabled = definirBox.Checked;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void opcionesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void numTiros_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Random rand = new Random();
            int a = (int)tamDadoBox.Value;
            cuadroResultado.Text= rand.Next(1,a+1).ToString(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cuadroResultado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tamDadoBox_ValueChanged(object sender, EventArgs e)
        {
            Bitmap imagen = null; // Declarar la variable fuera de las condiciones

            int valorDado = (int)tamDadoBox.Value;

            if (valorDado == 0)
            {
                imagen = Properties.Resources.dado_0;
            }
            else if (valorDado == 1)
            {
                imagen = Properties.Resources.dado_1;
            }
            else if (valorDado == 2)
            {
                imagen = Properties.Resources.dado_2;
            }
            else if (valorDado == 3)
            {
                imagen = Properties.Resources.dado_3;
            }
            else if (valorDado == 4)
            {
                imagen = Properties.Resources.dado_4;
            }
            else if (valorDado == 5)
            {
                imagen = Properties.Resources.dado_5;
            }
            else if (valorDado == 6)
            {
                imagen = Properties.Resources.dado_6;
            }
            else if (valorDado >= 7)
            {
                imagen = Properties.Resources.dado_gt7;
            }





            // Set the image to the PictureBox
            cuadroResultado.Image = imagen;
        }
    }
}
