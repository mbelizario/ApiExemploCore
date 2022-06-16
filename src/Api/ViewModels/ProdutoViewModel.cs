using Api.Constants;
using System.ComponentModel.DataAnnotations;

namespace Api.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = MensagemValidacao.CampoObrigatorio)]
        [StringLength(100, ErrorMessage = MensagemValidacao.CampoForaDoTamanhoDefinido, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = MensagemValidacao.CampoObrigatorio)]
        public int Valor { get; set; }
        public string NomeFornecedor { get; set; }
    }
}
