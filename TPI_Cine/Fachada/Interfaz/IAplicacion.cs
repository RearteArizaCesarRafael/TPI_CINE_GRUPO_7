using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Cine_Backend.Entidades;

namespace TPI_Cine_Backend.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Cliente> GetClientes();
        bool SaveTicket(Ticket oTicket);
        List<Funcion> GetFunciones();
    }
}
