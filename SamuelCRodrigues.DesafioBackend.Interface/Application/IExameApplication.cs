using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamuelCRodrigues.DesafioBackend.Interface.Application
{

    /// <summary>
    /// Representação da camada de aplicação do serviço de exame
    /// </summary>
    public interface IExameApplication
    {
        /// <summary>
        /// Retorna a Lista de Exames disponíveis para agendamento
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<IExame>> ListaExamesDisponiveisParaAgendamento();
    }
}
