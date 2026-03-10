namespace Churrasdora.Dominio.Modelos
{
    public class Convidados : Base
    {
        public int Homens { get; set; } = 0;
        public int Mulheres { get; set; } = 0;
        public int Idosos { get; set; } = 0;
        public int Criancas { get; set; } = 0;

        public int CalcularTotalPessoas()
        {
            return Homens + Mulheres + Idosos + Criancas;
        }

        public int CalcularTotalPagantes()
        {
            return Homens + Mulheres + Idosos;
        }
    }
}