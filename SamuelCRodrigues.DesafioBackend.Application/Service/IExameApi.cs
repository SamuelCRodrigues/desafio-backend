using Refit;
using SamuelCRodrigues.DesafioBackend.Application.ViewModel;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SamuelCRodrigues.DesafioBackend.Application.Service
{

    /// <summary>
    /// Interface com o(s) endpoint(s) de consumo da api(mock) de exames
    /// </summary>
    interface IExameApi
    {
        [Get("/v2/5d681ede33000054e7e65c3f")]
        Task<ExameCollectionVM> ListaExamesDisponiveisParaAgendamento();

    }
}
