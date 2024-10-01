using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;

namespace TurnosBack.Repositories
{
    public interface IServicioRepository
    {
        Task<List<TServicio>> GetAll();
    }
}
