using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L8_FORM_LFVV_1244416
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_SELECCION.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Selección Sumatoria");
                    TC_RESPUESTAS.SelectedTab = TP_SUMATORIA;
                    TB_INGRESARNSUMATORIA.Text = "";
                    LBL_RESULTADO2.Text = "";
                    break;

                case 1:
                    MessageBox.Show("Selección Tablas de Multiplicar");
                    TC_RESPUESTAS.SelectedTab = TP_MULTIPLICAR;
                    LBL_MULTIRESULTADO2.Text = "";
                    break;

                case 2:
                    MessageBox.Show("Selección Número Perfecto");
                    TC_RESPUESTAS.SelectedTab = TP_NPERFECTO;
                    TB_NPERFECTO.Text = "";
                    LBL_R2NPERFECTO.Text = "";
                    break;
            }
        }

        private void BTT_SELECCION_Click(object sender, EventArgs e)
        {
            int n=0,suma=0,contador=0;
            if (TC_RESPUESTAS.SelectedTab == TP_SUMATORIA)
            {
                n = int.Parse(TB_INGRESARNSUMATORIA.Text);
                suma = 0;
                contador = 0;
                do
                {
                    contador = contador + 1;
                    suma = suma + contador;
                } while (contador < n);

                LBL_RESULTADO2.Text = Convert.ToString(suma);
            }
            double n1=0,n2=0,multiplicacion = 0;
            if (TC_RESPUESTAS.SelectedTab == TP_MULTIPLICAR)
            {
                n1 = double.Parse(TB_N1MULTIPLICACION.Text);
                n2 = double.Parse(TB_N2MULTIPLICACION.Text);
                multiplicacion = Math.Round((n1 * n2), 2);
                LBL_MULTIRESULTADO2.Text= Convert.ToString(multiplicacion);
            }
            if (TC_RESPUESTAS.SelectedTab == TP_NPERFECTO)
            {
                n = int.Parse(TB_NPERFECTO.Text);
                if (n > 0)
                {
                    for (int i = 1; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            suma = suma + i;
                        }
                    }
                    if (suma == n)
                    {
                        LBL_R2NPERFECTO.Text=(n + " es un número perfecto");
                    }
                    if (suma != n)
                    {
                        LBL_R2NPERFECTO.Text = (n + " no es un número perfecto");
                    }
                }
                else if (n <= 0)
                {
                    LBL_R2NPERFECTO.Text = ("Error: Usted ha ingresado un valor menor o igual a 0");
                }
            }
        }

        private void TB_NPERFECTO_TextChanged(object sender, EventArgs e)
        {
            LBL_R2NPERFECTO.Text = "";
        }

        private void LBL_INGRESEN_Click(object sender, EventArgs e)
        {

        }

        private void TB_INGRESARNSUMATORIA_TextChanged(object sender, EventArgs e)
        {
            LBL_RESULTADO2.Text = "";
        }

        private void LBL_RESULTADO1_Click(object sender, EventArgs e)
        {

        }

        private void TB_N1MULTIPLICACION_TextChanged(object sender, EventArgs e)
        {
            LBL_MULTIRESULTADO2.Text = "";
        }

        private void TB_N2MULTIPLICACION_TextChanged(object sender, EventArgs e)
        {
            LBL_MULTIRESULTADO2.Text = "";
        }
    }
}
