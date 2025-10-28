using SCMM.Infra.Models;

namespace SCMM.Infra.Data
{
    public class AppDbContext
    {
        // Aqui simulamos o "DbSet" de uma tabela Equipamentos (sem precisar do banco real)
        public List<Equipamento> Equipamentos { get; set; } = new();

        public AppDbContext()
        {
            // Dados fictícios apenas para testes locais
            Equipamentos.Add(new Equipamento
            {
                Id = 1,
                Patrimonio = "PC-101",
                Hostname = "MEL-PC",
                NumeroSerie = "SN12345",
                Localizacao = "Escritório",
                Responsavel = "Mel",
                Observacoes = "Funcionando normalmente"
            });

            Equipamentos.Add(new Equipamento
            {
                Id = 2,
                Patrimonio = "PC-202",
                Hostname = "ADM-PC",
                NumeroSerie = "SN67890",
                Localizacao = "Financeiro",
                Responsavel = "Eduarda",
                Observacoes = "Troca de HD pendente"
            });
        }
    }
}
