using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;

        DateTime d = new DateTime();
        


        int resultado;

        double numDecimal1;
        double numDecimal2;
        double resultadoDecimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Suma()
        {
            try
            {
                num1 = Convert.ToInt32(TxtNum1.Text);
                num2 = Convert.ToInt32(TxtNum2.Text);
                resultado = num1 + num2;
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); //Muestra el mensaje de error
                MessageBox.Show(e.StackTrace); //Muestra la linea donde se produjo el mensaje y otros detalles
                
            }
            
        }

        private void Resta()
        {
            num1 = Convert.ToInt32(TxtNum1.Text);
            num2 = Convert.ToInt32(TxtNum2.Text);
            resultado = num1 - num2;
            lblResultado.Text = resultado.ToString();
        }

        private void Multiplica()
        {
            num1 = Convert.ToInt32(TxtNum1.Text);
            num2 = Convert.ToInt32(TxtNum2.Text);
            resultado = num1 * num2;
            lblResultado.Text = resultado.ToString();
        }

        private void Division()
        {
            try
            {

                numDecimal1 = Convert.ToDouble(TxtNum1.Text);
                numDecimal2 = Convert.ToDouble(TxtNum2.Text);
                resultadoDecimal = numDecimal1 / numDecimal2;
                lblResultado.Text = resultadoDecimal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Muestra el mensaje de error
                MessageBox.Show(ex.StackTrace); //Muestra la linea donde se produjo el mensaje y otros detalles

            }
        }

        private void Comparar()
        {
            try
            {
                numDecimal1 = Convert.ToDouble(TxtNum1.Text);
                numDecimal2 = Convert.ToDouble(TxtNum2.Text);

                if (numDecimal1 > numDecimal2)
                {
                    lblResultado.Text = numDecimal1 + " Es mayor que " + numDecimal2;
                }
                else if (numDecimal2 > numDecimal1)
                {
                    lblResultado.Text = numDecimal2 + " Es mayor que " + numDecimal1;
                }
                else
                {
                    lblResultado.Text = "Los numeros son iguales";

                }
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.Message);
            }
                    
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Division();
         
        }
        //Boton de suma
        private void button1_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Resta();
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            Multiplica();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Comparar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMes();
        }

        private void mostrarFecha()
        {
            d = DateTime.Now;
            TxtFecha.Text = d.ToString("dd.MM.yyy");
            
        }

        private void mostrarMes()
        {
            string mes= d.ToString("MM"); 
            switch (mes)
            {
                case "01":
                    LblDia.Text = "Enero";
                    break;
                case "02":
                    LblDia.Text = "Febrero";
                    break;
                case "03":
                    LblDia.Text = "Marzo";
                    break;
                case "04":
                    LblDia.Text = "Abril";
                    break;
                case "05":
                    LblDia.Text = "Mayo";
                    break;
                case "06":
                    LblDia.Text = "Junio";
                    break;
                case "07":
                    LblDia.Text = "Julio";
                    break;
                case "08":
                    LblDia.Text = "Agosto";
                    break;
                case "09":
                    LblDia.Text = "Septiembre";
                    break;
                case "10":
                    LblDia.Text = "Octubre";
                    break;
                case "11":
                    LblDia.Text = "Noviembre";
                    break;
                case "12":
                    LblDia.Text = "Diciembre";
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
