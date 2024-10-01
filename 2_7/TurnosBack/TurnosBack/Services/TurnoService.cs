using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosBack.Models;
using TurnosBack.Repositories;

namespace TurnosBack.Services
{
    public class TurnoService : ITurnosService
    {
        private readonly ITurnosRepository _turnosRepository;

        public TurnoService(ITurnosRepository turnoRepository)
        {
            _turnosRepository = turnoRepository;
        }
        public async Task<bool> CrearTurno(TTurno turno)
        {
            return await _turnosRepository.CrearTurno(turno);
        }

        public Task<List<TTurno>> Get(string fecha)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TTurno>> GetAll()
        {
            return await _turnosRepository.GetAll();
        }
    }
}
