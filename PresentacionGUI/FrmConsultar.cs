using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmConsultar : Form
    {
        private static readonly LiquidacionService liquidacionService = new LiquidacionService();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void bnVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarTabla();
        }

        public void VisualizarTabla()
        {
            var respuesta = liquidacionService.Consultar();
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                foreach (var item in respuesta.Persona)
                {
                    dgvTabla.Rows.Add(item.Identificacion, item.NombreEstablecimiento, item.ValorIngresoAnual, item.ValorGastoAnual, item.TipoResponsabilidad, item.TiempoFuncionamiento, item.Ganancia, item.Tarifa, item.ValorUVT,item.ValorLiquidacion);

                }
            }
        }
    }
}
