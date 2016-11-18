using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperacionesAritmeticas;

namespace FormularioOperacionesAritmeticas
{
  

    public partial class FormOperacionesAritmeticas : Form
    {
        
        Validacion v = new Validacion();
        public FormOperacionesAritmeticas()
        {
            InitializeComponent();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
        private void limpiarControles()
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            resultadoLabel.Text = "";
              
            
        }

        private void mcdRadioButton_Enter(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void mcmRadioButton_Enter(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void numero1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void numero2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void FormOperacionesAritmeticas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultadomx, resultadomin, resultados, resultador, resultadom, resultadod,resultadorc;
          //  double resultadorz;
            OperacionAritmetica operacionmx = new OperacionAritmetica();
            OperacionAritmetica operacionmin = new OperacionAritmetica();
            OperacionAritmetica operacions = new OperacionAritmetica();
            OperacionAritmetica operacionr = new OperacionAritmetica();
            OperacionAritmetica operacionm = new OperacionAritmetica();
            OperacionAritmetica operaciond= new OperacionAritmetica();
            OperacionAritmetica operacionrz = new OperacionAritmetica();
            OperacionAritmetica operacionrc= new OperacionAritmetica();
            resultadomx = operacionmx.maximoComunDivisor(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            resultadomin = operacionmin.minimoComunMultiplo(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            resultados = operacions.Sumar(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            resultador = operacionr.Restar(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            resultadom = operacionm.Multiplica(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            resultadod = operaciond.Division(Int32.Parse(txtNum1.Text), Int32.Parse(txtNum2.Text));
            //resultadorz = operacionrz.RaizCuadrada(double.Parse(txtNum1.Text));
            resultadorc= operacionrc.RaizCubica(Int32.Parse(txtNum1.Text));
            lblMaximoCD.Text = resultadomx.ToString();
            lblMinimoCD.Text = resultadomin.ToString();
            lblsuma.Text = resultados.ToString();
            lblResta.Text = resultador.ToString();
            lblMultiplica.Text = resultadom.ToString();
            lblDivision.Text = resultadod.ToString();
          //  lblRaizCuadrada.Text = resultadorz.ToString();
            lblRaizCubica.Text = resultadorc.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblDivision_Click(object sender, EventArgs e)
        {

        }

        private void lblRaizCuadrada_Click(object sender, EventArgs e)
        {

        }

        private void lblRaizCubica_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }
      

    }
    
}
