using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AutenticacaoAspNet.ViewModels
{
    public class LoginViewModel
    {
        public string UrlRetorno { get; set; }

        [Required(ErrorMessage  = "Informe o login")]
        [MaxLength(50, ErrorMessage = "O login dever ter até 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }
    }
}