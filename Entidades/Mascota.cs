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
        private int id;
        private string nombre;
        private string tipo;
        private string observacion;
        private DateTime fechaNacimiento;
        private string retirado;
        private int duenioId;
        #endregion

        #region Propiedades
        public int idProp
        {
            get { return id; }
            set { id = value; }
        }
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
        public string retiradoProp
        {
            get { return retirado; }
            set { retirado = value; }
        }
        public int duenioIdProp
        {
            get { return duenioId; }
            set { duenioId = value; }
        }
        #endregion

        #region Constructores
        public Mascota() { }
        public Mascota(string nom, string tip, string obs, DateTime fecNac, string ret)
        {
            nombre = nom;
            tipo = tip;
            observacion = obs;
            fechaNacimiento = fecNac;
            retirado = ret;
        }
        #endregion

        #region Metodos
        public void RetiradoM(bool retiradoM)
        {
            if (retiradoM == true)
            {
                retirado = "si";
            }
            else
            {
                retirado = "no";
            }
        }
        #endregion
    }
}
