using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;
using TurnosBack.Repositories;

namespace TurnosBack.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IServicioRepository _servicioRepository;

        public ServicioService(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }
        public async Task<List<TServicio>> GetAll()
        {
            return await _servicioRepository.GetAll();
        }
    }
}
