using System.ComponentModel.DataAnnotations; 

namespace MeteFlix.DataTransferObjects
{
    public class LoginDto
    {
      [Display(nameof = "E-mail ou Nome de Usuário")]
      [Required(ErroMessage = "Por favor, informe seu e-mail ou nome de usuário")]
      
      public string Email { get; set; }

      [Display(name = "Senha de Acesso")]
      [Required(ErroMessage = "Por favor, informe sua senha de acesso")]
      [Datatype(Datatype.Password)]
      public string Password { get; set; }
      [Display(nameof = "Manter Conectado?")]
      public bool RememberMe { get; set; }
      public string ReturnUrl { get; set; }  
    }
}