using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Teste1.Models
{
    [Table("Curriculos")]
    public class Curriculos

    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Funcao")]
        [Display(Name = "Função Pretendida")]
        public string Funcao { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public int CPF { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Dta_Nasc")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d}")]
        public DateTime Dta_Nasc { get; set; }

        [Column("Salario")]
        [Display(Name = "Pretenção Salarial")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public float Salario { get; set; }

        [Column("Obs")]
        [Display(Name = "Observações")]
        public string Obs { get; set; }

    }
}