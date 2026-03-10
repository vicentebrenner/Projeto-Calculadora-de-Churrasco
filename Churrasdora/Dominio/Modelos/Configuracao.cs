using System.Collections.Generic;

namespace Churrasdora.Dominio.Modelos
{
    public class Configuracao : Base
    {
        public List<string> CortesBovinos { get; set; } = new List<string>();
        public List<string> CortesSuinos { get; set; } = new List<string>();
        public List<string> CortesFrango { get; set; } = new List<string>();
        public List<string> Petiscos { get; set; } = new List<string>(); 

        public bool CalcularCarvao { get; set; } = true;

        public int CalcularTotalDeCortesSelecionados()
        {
            return CortesBovinos.Count + CortesSuinos.Count + CortesFrango.Count;
        }
    }
}