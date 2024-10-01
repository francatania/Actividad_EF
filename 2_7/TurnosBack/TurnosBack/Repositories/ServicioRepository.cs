using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;

namespace TurnosBack.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly TurnosDbContext _context;
        public ServicioRepository(TurnosDbContext context)
        {

            _context = context;

        }

        public async Task<List<TServicio>> GetAll()
        {
            return await _context.TServicios.ToListAsync();
        }
    }
}
