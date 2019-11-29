using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [StringLength(50,MinimumLength =5, ErrorMessage = "Esta menssagem deve possuir no minimo 5 caractere e no maximo 50.")]
        public string Observacoes { get; set; }

        [Range(18,70,ErrorMessage ="A idade tem que está entre 18 e 70 anos.")]
        public int Idade { get; set; }

        [RegularExpression(@"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i", ErrorMessage="Digite um email valido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres.")]
        [Required(ErrorMessage = "Login é obrigatório.")]
        [Remote("LoginUnico","Usuario",ErrorMessage = "Este login já existe.")]
        public string Login{ get; set; }

        [Required(ErrorMessage = " A senha é obrigatória.")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não se coincidem")]
        public string ConfirmaSenha { get; set; }
    }
}