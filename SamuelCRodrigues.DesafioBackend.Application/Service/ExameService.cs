using Newtonsoft.Json;
using Refit;
using SamuelCRodrigues.DesafioBackend.Application.ViewModel;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using SamuelCRodrigues.DesafioBackend.Interface.Service;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SamuelCRodrigues.DesafioBackend.Application.Service
{
    public class ExameService : IExameService
    {
        private readonly HttpClient _httpClient;
        private readonly IExameApi _exameApi;

        public ExameService(HttpClient httpClient) {
            _httpClient = httpClient;
            _exameApi = RestService.For<IExameApi>(_httpClient);
        }

        public async Task<IEnumerable<IExame>> ListaExamesDisponiveisParaAgendamento()
        {
            var result = await _exameApi.ListaExamesDisponiveisParaAgendamento();

            return result.Exams;
        }
    }
}
