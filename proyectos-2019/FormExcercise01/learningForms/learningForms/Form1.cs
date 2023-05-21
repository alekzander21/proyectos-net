using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learningForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            suma();
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            multiplicacion();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            division();
        }
        //Metodos para los botones
        private void suma()
        {
           decimal v1 = this.txtNumero01.Value;
           decimal v2 = this.txtNumero02.Value;
           decimal resultado = v1 + v2;

            this.lblResultado.Text = resultado + " ";
        }

        private void multiplicacion()
        {
            decimal v1 = this.txtNumero01.Value;
            decimal v2 = this.txtNumero02.Value;
            decimal resultado = v1 * v2;

            this.lblResultado.Text = resultado + " ";
        }

        private void division()
        {
            decimal v1 = this.txtNumero01.Value;
            decimal v2 = this.txtNumero02.Value;
            decimal resultado = v1 / v2;

            this.lblResultado.Text = resultado + " ";
        }


    }
}
