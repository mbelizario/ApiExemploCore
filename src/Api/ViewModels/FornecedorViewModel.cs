using Api.Constants;
using System.ComponentModel.DataAnnotations;

namespace Api.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = MensagemValidacao.CampoObrigatorio)]
        [StringLength(100, ErrorMessage = MensagemValidacao.CampoForaDoTamanhoDefinido, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = MensagemValidacao.CampoObrigatorio)]
        [StringLength(60, ErrorMessage = MensagemValidacao.CampoForaDoTamanhoDefinido, MinimumLength = 2)]
        public string Email { get; set; }
        public IEnumerable<ProdutoViewModel>? Produtos { get; set; }
    }
}
