﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(250, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo valor.")]
        [Range(typeof(decimal), "0", "999999999")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}