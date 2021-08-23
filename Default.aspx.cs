using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clienteASP_para_el_WS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);
            Double nro2 = Double.Parse(txtNro2.Text);

            respuesta = servicio.Sumar(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);
            Double nro2 = Double.Parse(txtNro2.Text);

            respuesta = servicio.Resta(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);
            Double nro2 = Double.Parse(txtNro2.Text);

            respuesta = servicio.Multiplicacion(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);
            Double nro2 = Double.Parse(txtNro2.Text);

            respuesta = servicio.Division(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnFact_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            int nro1 = int.Parse(txtNro1.Text);

            respuesta = servicio.Fact(nro1);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnPotencia_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            int nro1 = int.Parse(txtNro1.Text);
            int nro2 = int.Parse(txtNro2.Text);

            respuesta = servicio.Potencia(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);

            respuesta = servicio.Seno(nro1);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnTangente_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);

            respuesta = servicio.Tangente(nro1);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnInversa_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            Double nro1 = Double.Parse(txtNro1.Text);

            respuesta = servicio.inversa(nro1);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnRaizC_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            int nro1 = int.Parse(txtNro1.Text);

            respuesta = servicio.raiz_cuadrada(nro1);
            txtRespuesta.Text = respuesta.ToString();
        }

        protected void btnRaizN_Click(object sender, EventArgs e)
        {
            WSclienteASP.WebService1SoapClient servicio = new WSclienteASP.WebService1SoapClient();
            Double respuesta = 0;
            int nro1 = int.Parse(txtNro1.Text);
            int nro2 = int.Parse(txtNro2.Text);

            respuesta = servicio.raiz_n_esima(nro1, nro2);
            txtRespuesta.Text = respuesta.ToString();
        }
    }
}