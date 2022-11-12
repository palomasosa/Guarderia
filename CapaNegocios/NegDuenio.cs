using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;


namespace CapaNegocios
{
    public class NegDuenio
    {
        AdminisDuenio objDatosDuenio = new AdminisDuenio();
        public int abmDuenio(string accion, Duenio objDuenio)
        {
            return objDatosDuenio.abmDuenio(accion, objDuenio);
        }
        public DataSet listadoDuenios(string cual)
        {
            return objDatosDuenio.listadoDuenios(cual);
        }
        public List<DuenioCB> ObtenerDueniosCB()
        {
            return objDatosDuenio.ObtenerDueniosCB();
        }
    }
}
