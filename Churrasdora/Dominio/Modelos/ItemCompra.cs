namespace Churrasdora.Dominio.Modelos
{
    public class ItemCompra : Base
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
        public double ValorAproximado { get; set; }
        public bool Comprado { get; set; } = false; 
    }
}