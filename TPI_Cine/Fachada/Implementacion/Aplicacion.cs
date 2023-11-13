using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Cine_Backend.Datos.Interfaz;
using TPI_Cine_Backend.Entidades;
using TPI_Cine_Backend.Fachada.Interfaz;

namespace TPI_Cine_Backend.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private ITicketDao dao;
        public Aplicacion()
        {
            dao = new TicketDao();
        }
        public List<Cliente> GetClientes()
        {
            return dao.ObtenerClientes();
        }

        public List<Funcion> GetFunciones()
        {
            return dao.ObtenerFunciones();
        }

        public bool SaveTicket(Ticket oTicket)
        {
            return dao.CrearTicket(oTicket);
        }


    }
}
