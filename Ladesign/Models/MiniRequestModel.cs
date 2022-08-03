using System.ComponentModel.DataAnnotations;

namespace Ladesign.Models;

public class MiniRequestModel
{
    [Required(ErrorMessage = "Поле обязательно для ввода")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Поле обязательно для ввода")]
    public string? Telephone { get; set; }
}
