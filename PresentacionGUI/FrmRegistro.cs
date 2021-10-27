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
    public partial class FrmRegistro : Form
    {
        private static readonly LiquidacionService liquidacionService = new LiquidacionService();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
        public void LimpiarComponentes()
        {
            txtIdentificacion.Text = null;
            txtNombre.Text = null;
            txtGastoAnual.Text = null;
            txtIngresoAnual.Text = null;
            txtTiempo.Text = null;
            cbFiltrar.Text = null;
        }

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
            var persona = RegistrarDatos();
            string mensaje = liquidacionService.Guarda(persona);
            MessageBox.Show(mensaje);
            LimpiarComponentes();
        }

        public LiquidacionImpuesto RegistrarDatos()
        {
           long identificacion=long.Parse(txtIdentificacion.Text);
           string nombre=txtNombre.Text ;
           decimal gasto=decimal.Parse(txtGastoAnual.Text);
           decimal ingreso= decimal.Parse(txtIngresoAnual.Text);
           int tiempo= int.Parse(txtTiempo.Text);
           string filtro= cbFiltrar.Text;
            if (filtro.Equals("CON IVA"))
            {
                LiquidacionImpuesto iva = new ResponsableIVA (identificacion,nombre,ingreso,gasto,filtro, tiempo);
                iva.CalcularLiquidacion();
                return iva;
            }
            else if (filtro.Equals("SIN IVA"))
            {
                LiquidacionImpuesto sinIva = new NoResponsableIVA(identificacion, nombre, ingreso, gasto, filtro, tiempo);
                sinIva.CalcularLiquidacion();
                return sinIva;
            }
            else
            {
                LiquidacionImpuesto regimen  = new RegimenSimpleTributacion(identificacion, nombre, ingreso, gasto, filtro, tiempo);
               regimen.CalcularLiquidacion();
                return regimen;
            }
        }
    }
}
