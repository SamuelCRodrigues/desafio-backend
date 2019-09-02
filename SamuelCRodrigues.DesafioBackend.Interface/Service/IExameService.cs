using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamuelCRodrigues.DesafioBackend.Interface.Service
{
    /// <summary>
    /// Interface do Serviço de Exames
    /// </summary>
    public interface IExameService
    {
        /// <summary>
        /// Lista todos os exames disponíveis para agendamento
        /// </summary>
        /// <returns>Lista de Exames disponíveis para agendamento</returns>
        Task<IEnumerable<IExame>> ListaExamesDisponiveisParaAgendamento();
    }
}
