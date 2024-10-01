using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;

namespace TurnosBack.Services
{
    public interface IServicioService
    {
        Task<List<TServicio>> GetAll();
    }
}
