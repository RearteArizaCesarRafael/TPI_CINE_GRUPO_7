using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Cine_Backend.Entidades;

namespace TPI_Cine_Backend.Datos.Interfaz
{
    public interface IFuncionDao
    {
        public bool ActualizarFuncion(Ticket oTicket);
        public bool BorrarFuncion(int numero);
        public bool CrearFuncion(Ticket oTicket);
    }
}
