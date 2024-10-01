using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;

namespace TurnosBack.Repositories
{
    public class TurnoRepository : ITurnosRepository
    {
        private readonly TurnosDbContext _context;

        public TurnoRepository(TurnosDbContext context)
        {
            _context = context;
            
        }
        public async Task<bool> CrearTurno(TTurno turno)
        {
            bool result = false;
            try
            {
                _context.TTurnos.Add(turno);

                await _context.SaveChangesAsync();

                result = true;
            }
            catch (Exception exc)
            {

                throw exc;
            }

            return result;
        }

        public Task<List<TTurno>> Get(string fecha)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TTurno>> GetAll()
        {
           return await _context.TTurnos
                        .Include(t => t.TDetallesTurnos)
                        .ThenInclude(d => d.IdServicioNavigation)
                        .ToListAsync();
        }
    }
}
