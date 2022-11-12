using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DuenioCB
    {
        private int id;
        private string nombreApellido;

        public int idProp
        {
            get { return id; }
            set { id = value; }
        }
        public string nombreApellidoProp
        {
            get { return nombreApellido; }
            set { nombreApellido = value; }
        }

        public DuenioCB()
        {

        }
        public DuenioCB(int idConst, string nomAp)
        {
            id = idConst;
            nombreApellido = nomAp;
        }
    }
}
