using System.Collections.Generic;

namespace Churrasdora.Dominio.Modelos
{
    public class Resultado : Base
    {
        public double TotalCarneKg { get; set; } = 0.0;
        public double TotalPetiscosKg { get; set; } = 0.0;
        public int SacosCarvao { get; set; } = 0;
        
        public double GramasPorPessoa { get; set; } = 0.0;
        public double ValorTotal { get; set; } = 0.0;
        public double ValorPorPagante { get; set; } = 0.0;

        public List<ItemCompra> ListaDeCompras { get; set; } = new List<ItemCompra>();

        public int CalcularItensJaComprados()
        {
            int contador = 0;
            foreach (var item in ListaDeCompras)
            {
                if (item.Comprado)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}