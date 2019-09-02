using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuelCRodrigues.DesafioBackend.Domain.Models
{
    public class Exame : IExame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
