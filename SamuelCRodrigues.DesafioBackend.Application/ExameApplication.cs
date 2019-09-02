using SamuelCRodrigues.DesafioBackend.Interface.Application;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using SamuelCRodrigues.DesafioBackend.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SamuelCRodrigues.DesafioBackend.Application
{
    /// <summary>
    /// Camada de externalização do serviço de exames
    /// </summary>
    public class ExameApplication : IExameApplication
    {
        IExameService _exameService { get; set; }
        public ExameApplication(IExameService exameService)
        {
            _exameService = exameService;
        }

        /// <summary>
        /// Retorna a lista de exames Disponíveis para agendamento, já pronta com as regras necessárias para ser consumida via Api rest
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<IExame>> ListaExamesDisponiveisParaAgendamento() => await _exameService.ListaExamesDisponiveisParaAgendamento();
    }
}
