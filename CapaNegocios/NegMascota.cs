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
    public class NegMascota
    {
        AdminisMascota objDatosMascota = new AdminisMascota();
        public int abmMascota(string accion, Mascota objMascota)
        {
            return objDatosMascota.abmMascota(accion, objMascota);
        }
        public DataSet listadoMascotas(string cual)
        {
            return objDatosMascota.listadoMascotas(cual);
        }
    }
}
