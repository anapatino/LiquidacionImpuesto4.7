using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class LiquidacionRepository
    {
         string ruta = "ListaLiquidadasImpuesto.txt";

        public void Guardar(LiquidacionImpuesto paciente)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine(paciente.ToString());
            escritor.Close();
            file.Close();  
        }

        public List<LiquidacionImpuesto> Consultar()
        {
            List<LiquidacionImpuesto> personas = new List<LiquidacionImpuesto>();
            LiquidacionImpuesto persona;
            StreamReader lector = new StreamReader(ruta);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                persona = MapearLiquidacion(linea);
                personas.Add(persona);

            }
            lector.Close();
            return personas;
        }

        private static LiquidacionImpuesto MapearLiquidacion(string linea)
        {
            string[] dato = linea.Split(';');
            var liquidacion = CrearLiquidacion(dato[4]);
            liquidacion.Identificacion = long.Parse(dato[0]);
            liquidacion.NombreEstablecimiento = dato[1];
            liquidacion.ValorIngresoAnual = decimal.Parse(dato[2]);
            liquidacion.ValorGastoAnual = decimal.Parse(dato[3]);
            liquidacion.TipoResponsabilidad = dato[4];
            liquidacion.TiempoFuncionamiento = int.Parse(dato[5]);
            liquidacion.Ganancia = decimal.Parse(dato[6]);
            liquidacion.Tarifa = double.Parse(dato[7]);
            liquidacion.ValorUVT = double.Parse(dato[8]);
            liquidacion.ValorLiquidacion = decimal.Parse(dato[9]);
            return liquidacion;
        }
        public static LiquidacionImpuesto CrearLiquidacion(string tipoResponsabilidad)
        {
            LiquidacionImpuesto liquidacion;
            if (tipoResponsabilidad.Equals("CON IVA"))
            {
                liquidacion = new ResponsableIVA();
            }
            else if (tipoResponsabilidad.Equals("SIN IVA"))
            {
                liquidacion = new NoResponsableIVA();
            }
            else
            {
                liquidacion = new RegimenSimpleTributacion();
            }
            return liquidacion;
        }

        public void Eliminar(long identificacion)
        {
            List<LiquidacionImpuesto> persona = Consultar();
            File.Delete(ruta);
            foreach (var item in persona)
            {
                if (!item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
            }
        }
        public LiquidacionImpuesto Buscar(long identificacion)
        {
            bool resultado = File.Exists(ruta);
            if (resultado == true)
            {
                List<LiquidacionImpuesto> persona = Consultar();
                foreach (var item in persona)
                {
                    if (item.Identificacion.Equals(identificacion))
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public LiquidacionImpuesto FiltrarPorIdentificacion(long identificacion)
        {
            return (LiquidacionImpuesto)Consultar().FirstOrDefault(p => p.Identificacion.Equals(identificacion));
        }

        public List<LiquidacionImpuesto> FiltrarPorNombreDeEstablecimiento(string palabra)
        {
            return (from p in Consultar()
                    where p.NombreEstablecimiento.ToLower().Contains(palabra.ToLower())
                    select p).ToList();
        }

        public List<LiquidacionImpuesto> FiltarPorIngresoAnual(decimal valor)
        {
            return Consultar().Where(p => p.ValorIngresoAnual.Equals(valor)).ToList();
        }

        public List<LiquidacionImpuesto> FiltrarPorGastoAnual(decimal valor)
        {
            return Consultar().Where(p => p.ValorGastoAnual.Equals(valor)).ToList();
        }

        public List<LiquidacionImpuesto> FiltrarPorTipoResponsabilidad(string responsabilidad)
        {
            return Consultar().Where(p => p.TipoResponsabilidad.ToUpper().Equals(responsabilidad)).ToList();
        }

        public List<LiquidacionImpuesto> FiltrarPorTiempoDeFuncionamiento(int tiempo)
        {
            return Consultar().Where(p=> p.TiempoFuncionamiento.Equals(tiempo)).ToList();
        }



    }
}
