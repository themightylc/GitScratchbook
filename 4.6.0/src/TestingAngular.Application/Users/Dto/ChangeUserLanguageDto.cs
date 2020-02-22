using System.ComponentModel.DataAnnotations;

namespace TestingAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}