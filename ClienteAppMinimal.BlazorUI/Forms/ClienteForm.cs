using System.ComponentModel.DataAnnotations;

namespace ClienteAppMinimal.BlazorUI.Forms
{
    public class ClienteForm
    {
        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        public string? Email { get; set; }
    }
}
