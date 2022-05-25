using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Teste1.Models
{
    [Table("Vagas")]
    public class Vagas
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Funcao")]
        [Display(Name = "Função")]
        public string Funcao { get; set; }

        [Column("Nme_Empresa")]
        [Display(Name = "Nome da Empresa")]
        public string Nme_Empresa { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("DescVaga")]
        [Display(Name = "Descrição da Vaga")]
        public string Desc_Vaga { get; set; }

        [Column("Salario")]
        [Display(Name = "Salário")]
        public float Salario { get; set; }

        [Column("Dta_Cadastro")]
        [Display(Name = "Data de Cadastro")]
        public DateTime Dta_Cadastro { get; set; }


    }

}
