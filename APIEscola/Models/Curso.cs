using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {

        public Guid CursoId { get; set; }
        [Required(ErrorMessage = "O campo sigla é obrigatório.")] //Campo obrigatório
        [MaxLength(19, ErrorMessage = "A sigla deve ter no máximo 10 caracteres.")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres.")]
        public string Descricao { get; set; }

    }
}
