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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        public void LimpiarComponentes()
        {
            dgvTabla.Visible = false;
            dgvTabla.Rows.Clear();
            cbFiltrar.Text = null;
            txtBusqueda.Text = null;
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            ValidarFiltro();
        }

        private void ValidarFiltro()
        {
            string filtro = cbFiltrar.Text;
            if (filtro.Equals("IDENTIFICACION"))
            {
                VisualizarIdentificacion();
            }
            else if (filtro.Equals("ESTABLECIMIENTO"))
            {
                VisualizarNombre();
            }
            else if (filtro.Equals("INGRESO"))
            {
                VisualizarIngreso();
            }
            else if (filtro.Equals("GASTO"))
            {
                VisualizarGasto();
            }
            else if (filtro.Equals("RESPONSABILIDAD"))
            {
                VisualizarResponsabilidad();
            }
            else if (filtro.Equals("TIEMPO"))
            {
                VisualizarTiempo();
            }
        }

        public void VisualizarIdentificacion()
        {
            long identificacion =long.Parse( txtBusqueda.Text);
            LiquidacionService personaService = new LiquidacionService();
            var personaBuscada = personaService.ConsultarPorIdentificacion(identificacion);
            ValidarSiExiste(personaBuscada);
        }
        public void ValidarSiExiste(LiquidacionBuscarResponse personaBuscada)
        {
            if (personaBuscada.IsError == false)
            {
                ActivarTabla(personaBuscada.Persona);
            }
            MessageBox.Show(personaBuscada.Mensaje);
        }

        public void VisualizarNombre()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionService personaService = new LiquidacionService();
            string nombre = txtBusqueda.Text;
            respuesta = personaService.ConsultarPorNombreEstablecimiento(nombre);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarIngreso()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionService personaService = new LiquidacionService();
            decimal valor = decimal.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorIngresoAnual(valor);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarGasto()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionService personaService = new LiquidacionService();
            decimal valor = decimal.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorGastoAnual(valor);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarResponsabilidad()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionService personaService = new LiquidacionService();
            string tipo = txtBusqueda.Text;
            respuesta = personaService.ConsultarPorTipoResponsabilidad(tipo);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarTiempo()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionService personaService = new LiquidacionService();
            int tiempo =int.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorTiempoFuncionamiento(tiempo);
            AgregarRegistroPanel(respuesta);
        }

        public void ActivarTabla(LiquidacionImpuesto item)
        {
            dgvTabla.Visible = true;
            dgvTabla.Rows.Add(item.Identificacion, item.NombreEstablecimiento, item.ValorIngresoAnual, item.ValorGastoAnual, item.TipoResponsabilidad, item.TiempoFuncionamiento, item.Ganancia, item.Tarifa, item.ValorUVT, item.ValorLiquidacion);
        }

        public void AgregarRegistroPanel(LiquidacionConsultaResponse respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvTabla.Visible = true;
                foreach (var item in respuesta.Persona)
                {
                    dgvTabla.Rows.Add(item.Identificacion, item.NombreEstablecimiento, item.ValorIngresoAnual, item.ValorGastoAnual, item.TipoResponsabilidad, item.TiempoFuncionamiento, item.Ganancia, item.Tarifa, item.ValorUVT, item.ValorLiquidacion);
                }

            }
        }
    }
}
