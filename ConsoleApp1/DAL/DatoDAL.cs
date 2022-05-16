using ConsoleApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAL
{
    public class DatoDAL
    {
        /*
        private List<DatoDTO> listaDatos;

        public DatoDAL()
        {
            this.listadatos = new List<DatoDTO>();
        }
        public bool Insertar(DatoDTO datos) {
            return DatoDTO.Add(datos);

        }
        */

        public bool Actualizar(DatoDTO datos) {
            return true;
        }
        public bool Eliminar(DatoDTO datos) {
            return true;
        }

        public List<DatoDTO> List()
        {
            return DatoDTO.List();
        }
    }
}
