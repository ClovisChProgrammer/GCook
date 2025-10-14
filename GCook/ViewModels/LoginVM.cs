using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu email ou nome de usuário")]
        [Required(ErrorMessage = "O Email ou o Nome de Usuário é obrigatório.")]
        public string Email { get; set;}

    [Display(Name =  "Senha de Acesso", Prompt = "****************")]
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Senha { get; set;}

    [Display(Name =  "Email ou Nome de Usuário", Prompt = "Informe seu email ou nome de usuário")]
        [Required(ErrorMessage = "O Email ou o Nome de Usuário é obrigatório.")]
        public bool Lembrar { get; set;} = false;

    [Display(Name =  "Email ou Nome de Usuário", Prompt = "Informe seu email ou nome de usuário")]
        [Required(ErrorMessage = "O Email ou o Nome de Usuário é obrigatório.")]
        public string UrlRetorno { get; set;}

    }
}