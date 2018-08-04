using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace AutenticacaoAspNet.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(50, ErrorMessage = "O nome deve ter até 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu Login")]
        [MaxLength(30, ErrorMessage = "O Login deve ter até 30 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelomenos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Comfirme sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelomenos 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a comfirmação não estão iguais")]
        public string ComfirmacaoSenha { get; set; }
    }
}