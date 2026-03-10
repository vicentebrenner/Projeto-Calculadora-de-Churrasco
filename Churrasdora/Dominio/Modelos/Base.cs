namespace Churrasdora.Dominio.Modelos
{
    public abstract class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}