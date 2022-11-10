using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {

        #region Atributos
        private string nombre;
        public string tipo;
        public string observacion;
        public DateTime fechaNacimiento;
        public bool retirado;
        #endregion

        #region Propiedades
        public string nombreProp
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string tipoProp
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string observacionProp
        {
            get { return observacion; }
            set { observacion = value; }
        }
        public DateTime fechaNacimientoProp
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public bool retiradoProp
        {
            get { return retirado; }
            set { retirado = value; }
        }
        #endregion

        #region Constructores
        public Mascota() { }
        public Mascota(string nom, string tip, string obs, DateTime fecNac, bool ret)
        {
            nombre = nom;
            tipo = tip;
            observacion = obs;
            fechaNacimiento = fecNac;
            retirado = ret;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
