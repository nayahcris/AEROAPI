using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AEROAPI.Model;
using AEROAPI.Request;
    
namespace AEROAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private List<Reserva> Reservas = new List<Reserva>();
        private int Id = 1;
        [HttpPost]
        public IActionResult EfetuarReserva(EfetuarReservaRequest request)
        {
            return null;
        }
    
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return null;
        }
    
        [HttpGet("buscarPorVoo{VooID}")]
        public IActionResult BuscarPorVoo(int id)
        {
            return null;
        }
    
        [HttpPut]
        public IActionResult Editar(EditarReservaRequest request)
        {
            return null;
        }
    
        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            return null;
        }
    
        
        }
}