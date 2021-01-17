using System.ComponentModel.DataAnnotations;

namespace Liz.VueApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}