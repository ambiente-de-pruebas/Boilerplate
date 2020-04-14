using System.ComponentModel.DataAnnotations;

namespace ProyectoBase.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}