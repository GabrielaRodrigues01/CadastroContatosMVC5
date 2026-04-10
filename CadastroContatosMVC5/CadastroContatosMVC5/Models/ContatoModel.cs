using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatosMVC5.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [StringLength(300, ErrorMessage = "Máximo de 300 caracteres.")]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}