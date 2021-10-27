using Entidad;
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
    public partial class FrmEliminar : Form
    {
        private static readonly LiquidacionService liquidacionService = new LiquidacionService();
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }

        public void Visualizar()
        {
            long numeroLiquidacion = long.Parse(txtBusqueda.Text);
            var (mensaje, personaEliminada) = liquidacionService.Eliminar(numeroLiquidacion);
            if (mensaje.Equals($"Se Eliminó el registro de la persona con identificacion {numeroLiquidacion}"))
            {
                ActivarTabla(personaEliminada);
            }
            MessageBox.Show(mensaje);
           
        }

        public void ActivarTabla(LiquidacionImpuesto item)
        {
            dgvTabla.Visible = true;
            dgvTabla.Rows.Add(item.Identificacion, item.NombreEstablecimiento, item.ValorIngresoAnual, item.ValorGastoAnual, item.TipoResponsabilidad, item.TiempoFuncionamiento, item.Ganancia, item.Tarifa, item.ValorUVT, item.ValorLiquidacion);
        }

        public void LimpiarComponentes()
        {
            dgvTabla.Rows.Clear();
            dgvTabla.Visible = false;
            txtBusqueda.Text = null;
        }
    }
}
