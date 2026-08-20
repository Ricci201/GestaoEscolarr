using System.ComponentModel.DataAnnotations;

namespace GestaoEscolarr;

public class UnidadeCurricular
{
    public Guid id {get; set;}

    [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
    [StringLength(50, ErrorMessage = "O Campo Nome deve ter entre 3 e 50 caracteres!" )]
    [MinLength(3, ErrorMessage = "O Campo Nome deve ter entre 3 e 50 caracteres!")]
    public string Nome {get; set;}
    
    [Required(ErrorMessage = "O Campo Carga Horária é Obrigatório!")]
    [Display(Name = "Carga Horária")]
    [Range(1,400 )]
    public int CargaHoraria {get; set;}

    [Required(ErrorMessage = "O Campo Sigla é Obrigatório!")]
    [MaxLength(10, ErrorMessage = "O Campo Sigla deve ter entre 3 e 10 caracteres!" )]
    [MinLength(3, ErrorMessage = "O Campo Sigla deve ter entre 3 e 10 caracteres!")]
    public string Sigla {get; set;}
}
