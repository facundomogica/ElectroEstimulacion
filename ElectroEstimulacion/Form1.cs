using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroEstimulacion
{

    public partial class Form1 : Form
    {
        public int frecuencia=2000, modulacion_Inf=0, modulacion_Sup = 0, corriente=0,tiempo=0;
        bool Estado=false; //falso=apagado; verdadero=encendido

        public Form1()
        {
            InitializeComponent();
        }
       private static void main()
        {
            

        }
  
        private void Subir_Frecuencia_Click_1(object sender, EventArgs e)
        {
            if (frecuencia < 9950)
            {
                frecuencia = frecuencia + 50;

            }
            else if (frecuencia == 9950)
            {
                frecuencia = 10000;
                Frec_text.Text = frecuencia.ToString()+ "Hz";
                return;
            }
            else { return; }
            string Texto = frecuencia.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 4 - largo); //creo el auxiliar para los ceros de adelante
            Frec_text.Text =  aux+ Texto + " Hz";
        }

        private void Subir_Modulacion_Click(object sender, EventArgs e)
        {
            if (modulacion_Inf < 140)
            {
                modulacion_Inf = modulacion_Inf + 5;

            }
            else if (modulacion_Inf == 140)
            {
                modulacion_Inf = 145;
                Mod_Inf_text.Text = modulacion_Inf.ToString();
                return;
            }
            else { return; }
            string Texto = modulacion_Inf.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Mod_Inf_text.Text = aux + Texto ;
        }

        private void Bajar_Modulacion_Click(object sender, EventArgs e)
        {
            if (modulacion_Inf > 0)
            {
                modulacion_Inf = modulacion_Inf - 5;
            }
            string Texto = modulacion_Inf.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Mod_Inf_text.Text = aux + Texto;
        }

        private void Subir_Corriente_Click(object sender, EventArgs e)
        {
            if (corriente < 99)
            {
                corriente = corriente + 1;

            }
            else if (corriente == 145)
            {
                corriente = 150;
                Mod_Inf_text.Text = corriente.ToString() + " Hz";
                return;
            }
            else { return; }
            string Texto = corriente.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Corr_text.Text = aux + Texto + " ma";
        }

        private void Bajar_Corriente_Click(object sender, EventArgs e)
        {
            if (corriente > 0)
            {
                corriente = corriente - 1;
            }
            string Texto = corriente.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Corr_text.Text = aux + Texto + " ma";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subir_Modulacion_Sup_Click(object sender, EventArgs e)
        {
            if (modulacion_Sup < 145)
            {
                modulacion_Sup = modulacion_Sup + 5;

            }
            else if (modulacion_Sup == 145)
            {
                modulacion_Sup = 150;
                Mod_Sup_text.Text = modulacion_Sup.ToString();
                return;
            }
            else { return; }
            string Texto = modulacion_Sup.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Mod_Sup_text.Text = aux + Texto;
        }

        private void Subir_Tiempo_Click(object sender, EventArgs e)
        {
            if (tiempo < 30)
            {
                tiempo = tiempo + 1;

            }
            
            
            string Texto = tiempo.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 2 - largo); //creo el auxiliar para los ceros de adelante
            Tiem_text.Text = aux + Texto;
        }

        private void Bajar_Tiempo_Click(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
            }
            string Texto = tiempo.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 2 - largo); //creo el auxiliar para los ceros de adelante
            Tiem_text.Text = aux + Texto;
        }

        private void boton_Circular6_Click(object sender, EventArgs e)
        {

        }

        private void boton_Encendido_Click(object sender, EventArgs e)
        {
            if (Estado == false)
            { Estado = true; Estado_Encendido(); }
            else { Estado = false; Estado_Apagado(); }

        }
        private void Estado_Encendido()
        {
            led_Encendido.BackColor = Color.LightGreen;
        }
        private void Estado_Apagado()
        {
            led_Encendido.BackColor = Color.DimGray;
        }
        private void Bajar_Modulacion_Sup_Click(object sender, EventArgs e)
        {
            if (modulacion_Sup > 0)
            {
                modulacion_Sup = modulacion_Sup - 5;
            }
            string Texto = modulacion_Sup.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 3 - largo); //creo el auxiliar para los ceros de adelante
            Mod_Sup_text.Text = aux + Texto;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bajar_Frecuencia_Click(object sender, EventArgs e)
        {
            if (frecuencia > 0)
            {
                frecuencia = frecuencia - 50;
            }
            string Texto = frecuencia.ToString();
            int largo = Texto.Length;
            string aux = new string('0', 4 - largo); //creo el auxiliar para los ceros de adelante
            Frec_text.Text = aux + Texto + " Hz";
        }

      
        private void Frec_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
