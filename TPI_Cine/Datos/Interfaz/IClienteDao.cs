using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Cine_Backend.Entidades;

namespace TPI_Cine_Backend.Datos.Interfaz
{
    public interface IClienteDao
    {
        public bool ActualizarCliente(Ticket oTicket);
        public bool BorrarCliente(int numero);
        public bool CrearCliente(Ticket oTicket);
    }
}
