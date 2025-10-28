namespace SCMM.Infra.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Patrimonio { get; set; } = string.Empty;
        public string Hostname { get; set; } = string.Empty;
        public string NumeroSerie { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
        public string Responsavel { get; set; } = string.Empty;
        public string Observacoes { get; set; } = string.Empty;
    }
}
