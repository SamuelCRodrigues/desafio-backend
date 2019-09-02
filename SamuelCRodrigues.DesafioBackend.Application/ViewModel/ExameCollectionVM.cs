using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuelCRodrigues.DesafioBackend.Application.ViewModel
{
    /// <summary>
    /// Objeto que representa o formato de recebimento da api(mock) de exames
    /// </summary>
    public class ExameCollectionVM 
    {
        public IEnumerable<ExameVM> Exams { get; set; }
    }
}
