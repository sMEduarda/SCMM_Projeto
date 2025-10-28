using SCMM.Infra.Data;
using SCMM.Infra.Models;

namespace SCMM.Application.Controllers
{
    public class EquipamentoController
    {
        private readonly AppDbContext _context = new();

        // LISTAR equipamentos (com filtro opcional)
        public List<Equipamento> Listar(string? filtro = null)
        {
            var query = _context.Equipamentos.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim().ToLower();
                query = query.Where(e =>
                    e.Patrimonio.ToLower().Contains(filtro) ||
                    e.Hostname.ToLower().Contains(filtro) ||
                    e.Localizacao.ToLower().Contains(filtro) ||
                    e.Responsavel.ToLower().Contains(filtro));
            }

            return query.OrderBy(e => e.Patrimonio).ToList();
        }

        // OBTER um equipamento específico pelo Id
        public Equipamento? ObterPorId(int id)
        {
            return _context.Equipamentos.FirstOrDefault(e => e.Id == id);
        }

        // CRIAR novo equipamento
        public void Criar(Equipamento e)
        {
            e.Id = _context.Equipamentos.Max(x => x.Id) + 1;
            _context.Equipamentos.Add(e);
        }

        // ATUALIZAR equipamento existente
        public void Atualizar(Equipamento e)
        {
            var existente = _context.Equipamentos.FirstOrDefault(x => x.Id == e.Id);
            if (existente == null) return;

            existente.Patrimonio = e.Patrimonio;
            existente.Hostname = e.Hostname;
            existente.NumeroSerie = e.NumeroSerie;
            existente.Localizacao = e.Localizacao;
            existente.Responsavel = e.Responsavel;
            existente.Observacoes = e.Observacoes;
        }

        // EXCLUIR equipamento
        public void Excluir(int id)
        {
            var item = _context.Equipamentos.FirstOrDefault(x => x.Id == id);
            if (item != null)
                _context.Equipamentos.Remove(item);
        }
    }
}
