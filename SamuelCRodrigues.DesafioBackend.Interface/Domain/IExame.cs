namespace SamuelCRodrigues.DesafioBackend.Interface.Domain
{
    /// <summary>
    /// Representação do Objeto de Domínio Exame
    /// </summary>
    public interface IExame
    {
        int Id { get; set; }
        string Name { get; set; }
        double Value { get; set; }
    }
}
