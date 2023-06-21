using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do genero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string Diretor { get; set; }
    [Required(ErrorMessage = "O valor da duração não é valido")]
    [Range(1,360, ErrorMessage = "A duração deve ser entre 1 a 360 minutos")]
    public int Duracao { get; set; }

}
