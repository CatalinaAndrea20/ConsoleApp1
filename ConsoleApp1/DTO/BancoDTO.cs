using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DTO
{
    public class BancoDTO
    {
        private int id;
        private int numero;
        private CeldaDTO[] celdas;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public CeldaDTO[] Celdas { get; set; }

        public BancoDTO()
        {
            this.celdas = new CeldaDTO[0];  
        }

        public BancoDTO(int id, int numero, CeldaDTO[] celdas)
        {
            this.id = id;
            this.numero = numero;
            this.celdas = celdas;
        }
    }
}
