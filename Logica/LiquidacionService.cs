using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LiquidacionService
    {
        readonly LiquidacionRepository liquidacionRepository;
        public LiquidacionService()
        {
            liquidacionRepository = new LiquidacionRepository();
        }
        public string Guarda(LiquidacionImpuesto persona)
        {
            try
            {
                liquidacionRepository.Guardar(persona);
                return "Se guardo el registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Guardar: {e.Message}";
            }
        }
        public LiquidacionConsultaResponse Consultar()
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.Consultar());
            }
            catch (Exception e)
            {

                return new LiquidacionConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
        }
        public (string, LiquidacionImpuesto) Eliminar(long numeroLiquidacion)
        {
            try
            {
                var personaEliminada = liquidacionRepository.Buscar(numeroLiquidacion);
                if (personaEliminada != null)
                {
                    liquidacionRepository.Eliminar(numeroLiquidacion);
                    return ($"Se Eliminó el registro de la persona con identificacion {numeroLiquidacion}", personaEliminada);
                }
                return ($"No fue posible eliminar el registro, porque no existe la persona con la identificacion {numeroLiquidacion}", personaEliminada);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Eliminar: {e.Message}", null);
            }

        }
        public string Busca(long identificacion)
        {
            try
            {
                if (liquidacionRepository.Buscar(identificacion) != null)
                {
                    return $"Ya se encuentra un registro con Nro.Identificacion ({identificacion})";
                }
                return "Identificacion Generada correctamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar: {e.Message}";
            }
        }

        public LiquidacionBuscarResponse ConsultarPorIdentificacion(long identificacion)
        {
            try
            {
                var paciente = liquidacionRepository.FiltrarPorIdentificacion(identificacion);
                if (paciente == null)
                {
                    throw new PersonaNoEncontradoException("No se encontró un registro con el Nro.Identificacion Solicitada");
                }
                return new LiquidacionBuscarResponse(paciente);
            }
            catch (PersonaNoEncontradoException e)
            {
                return new LiquidacionBuscarResponse($"Error al Buscar Nro Liquidacion :{e.Message}");
            }
        }

        public LiquidacionConsultaResponse ConsultarPorNombreEstablecimiento(string establecimiento)
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.FiltrarPorNombreDeEstablecimiento(establecimiento));
            }
            catch (Exception e)
            {
                return new LiquidacionConsultaResponse("Se presento el siguiente: " + e.Message);
            }
        }

        public LiquidacionConsultaResponse ConsultarPorGastoAnual(decimal valor)
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.FiltrarPorGastoAnual(valor));
            }
            catch (Exception e)
            {
                return new LiquidacionConsultaResponse("Se presento el siguiente: " + e.Message);
            }
        }

        public LiquidacionConsultaResponse ConsultarPorIngresoAnual(decimal valor)
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.FiltarPorIngresoAnual(valor));
            }
            catch (Exception e)
            {
                return new LiquidacionConsultaResponse("Se presento el siguiente: " + e.Message);
            }
        }

        public LiquidacionConsultaResponse ConsultarPorTipoResponsabilidad(string tipo)
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.FiltrarPorTipoResponsabilidad(tipo));
            }
            catch (Exception e)
            {
                return new LiquidacionConsultaResponse("Se presento el siguiente: " + e.Message);
            }
        }

        public LiquidacionConsultaResponse ConsultarPorTiempoFuncionamiento(int anio)
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.FiltrarPorTiempoDeFuncionamiento(anio));
            }
            catch (Exception e)
            {
                return new LiquidacionConsultaResponse("Se presento el siguiente: " + e.Message);
            }
        }

    }
}
