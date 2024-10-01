using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;

namespace TurnosBack.Services
{
    public interface ITurnosService
    {
        Task<List<TTurno>> GetAll();

        Task<List<TTurno>> Get(string fecha);

        Task<bool> CrearTurno(TTurno turno);
    }
}
