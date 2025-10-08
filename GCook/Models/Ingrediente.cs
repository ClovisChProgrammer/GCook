using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization.Infrastructure;
namespace GCook.Models;

[Table("Ingrediente")]

    public class Ingrediente
    {
       [Key]
       public int Id {get; set;}

       [StringLength(300)] 

       public string Foto {get; set;}


       [Display(NameAuthorizationRequirement = "Exibir na Home?")]

       public bool ExibirHome {get; set;}

    }
