using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Ladesign.Models;

public class RequestModel
{
    [Required(ErrorMessage = "Поле обязательно для ввода")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Поле обязательно для ввода")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "Неверный формат эл.почты")]
    public string? Email { get; set; }

    public string? Answer { get; set; }

    public IBrowserFile? File { get; set; }
}
