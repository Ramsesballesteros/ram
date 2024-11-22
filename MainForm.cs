/*
 * Created by SharpDevelop.
 * User: CC-PC47
 * Date: 14/11/2024
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rgea
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			try
			{
				double area = double.Parse(txtArea.Text);
				//costos
				double costoBultoAserrin = double.Parse(txtBultos.Text);
                double costoLitroPintura = double.Parse(txtCostoPintura.Text);
                double costoKgFrutosSecos = double.Parse(txtCostoFrutosSecos.Text);
                double costoDocenaFlores = double.Parse(txtCostoFlores.Text);
                double costoLitroAgua = double.Parse(txtLitrosAgua.Text);
                double costoHoraDiseno = double.Parse(txtHorasDiseno.Text);
                double costoManoObra = double.Parse(txtCostoManoObra.Text);
                double costoAlimentosPorPersona = double.Parse(txtCostoAlimentos.Text);
                //cantidades
                double cantidadBultos = double.Parse(txtBultos.Text);
                double cantidadLitrosPintura = double.Parse(txtLitrosPintura.Text);
                double cantidadKgFrutosSecos = double.Parse(txtKgFrutosSecos.Text);
                double cantidadDocenasFlores = double.Parse(txtDocenasFlores.Text);
                double cantidadLitrosAgua = double.Parse(txtLitrosAgua.Text);
                double horasDiseno = double.Parse(txtHorasDiseno.Text);
                int numeroPersonas = int.Parse(txtPersonas.Text);
                //calculos 
                double costoAserrin = cantidadBultos * costoBultoAserrin;
                double costoPintura = cantidadLitrosPintura * costoLitroPintura;
                double costoFrutosSecos = cantidadKgFrutosSecos * costoKgFrutosSecos;
                double costoFlores = cantidadDocenasFlores * costoDocenaFlores;
                double costoAgua = cantidadLitrosAgua * costoLitroAgua;
                double costoDiseno = horasDiseno * costoHoraDiseno;
                double costoAlimentos = numeroPersonas * costoAlimentosPorPersona;
                double costoManoDeObra = numeroPersonas * costoManoObra;
                //costo total
              	double costoTotal = costoAserrin + costoPintura + costoFrutosSecos +
                                    costoFlores + costoAgua + costoDiseno +
                                    costoAlimentos + costoManoDeObra;
              	//mostrar resultado)
              	labelresultado.Text = "Costo Total: $" + costoTotal.ToString("F2");
        	}
			catch (Exception ex)
			{
				MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void TxtAreaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label13Click(object sender, EventArgs e)
		{
			
		}
	}
}
