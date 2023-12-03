using System.ComponentModel.DataAnnotations;

namespace ProjetoAspNetAPI01.Services.Models
{
    public class ClienteCadastroModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        public string Email { get; set; }
    }
}
