using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_Humanos.Context;
using api_Humanos.Models;

namespace api_Humanos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        private readonly context _context;

        public OperacionesController(context context)
        {
            _context = context;
        }


        // GET: api/Humanos/5
        [HttpGet]
        public async Task<ActionResult<OperacionesOutput>> GetOperaciones([FromQuery] OperacionesInput operacionesInput)
        {
            try
            {
                var resultado = (operacionesInput.PrimerNumero + operacionesInput.SegundoNumero) * operacionesInput.TercerNumero;

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        // POST: api/Operaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OperacionesOutput>> PostOperaciones(OperacionesInput operacionesInput)
        {
            try
            {
                var resultado = (operacionesInput.PrimerNumero * operacionesInput.SegundoNumero) - operacionesInput.TercerNumero;

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
