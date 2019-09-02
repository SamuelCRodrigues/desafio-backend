using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamuelCRodrigues.DesafioBackend.Application.Service;
using SamuelCRodrigues.DesafioBackend.Interface.Application;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using SamuelCRodrigues.DesafioBackend.Interface.Service;

namespace SamuelCRodrigues.DesafioBackend.Api.Controllers
{
    /// <summary>
    /// Api Restfull de acesso aos exames
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExamesController : ControllerBase
    {
        private IExameApplication _app;

        public ExamesController(IExameApplication exameApplication) {
            _app = exameApplication;
        }

        /// <summary>
        /// Retorna a lista de exames disponíveis para agendamento
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<IExame>> Get()
        {
            return await _app.ListaExamesDisponiveisParaAgendamento();
        }


    }
}
