using Newtonsoft.Json;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;

namespace SamuelCRodrigues.DesafioBackend.Application.ViewModel
{
    /// <summary>
    /// Representação do Objeto de Exame para externalização via Api
    /// </summary>
    public class ExameVM : IExame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public double Value { get; set; }
    }
}
