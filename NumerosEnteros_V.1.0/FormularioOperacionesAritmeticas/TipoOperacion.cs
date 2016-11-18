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
        bool calculado=false;
        Validacion v = new Validacion();
        public FormOperacionesAritmeticas()
        {
            InitializeComponent();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
          
            int resultado;
            OperacionAritmetica operacion = new OperacionAritmetica();

            if (mcdRadioButton.Checked == true)
                resultado = operacion.maximoComunDivisor(Int32.Parse(numero1TextBox.Text),Int32.Parse(numero2TextBox.Text));
            else
                resultado = operacion.minimoComunMultiplo(Int32.Parse(numero1TextBox.Text), Int32.Parse(numero2TextBox.Text));

            resultadoLabel.Text = resultado.ToString();
            calculado = true;
        }

        private void numero1TextBox_Enter(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void numero2TextBox_Enter(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            if (calculado)
            {
                numero1TextBox.Text = "";
                numero2TextBox.Text = "";
                resultadoLabel.Text = "";
                calculado = false;
            }
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

        private void numero1TextBox_TextChanged(object sender, EventArgs e)
        {

        }
      

    }
    
}
