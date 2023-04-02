using System.ComponentModel.DataAnnotations;
using Board.Contracts.Attributes;

namespace Board.Contracts.Posts;

/// <summary>
/// Модель создания объявления
/// </summary>

public class CreatePostDto
{
    
    /// <summary>
    /// Название поста
    /// </summary>
    
    [Required]
    [StringLength(15, ErrorMessage = "Наименование слишком длинное")]
    [NameValidation]
    public string Name { get; set; }

    
    /// <summary>
    /// Описание поста
    /// </summary>
    
    [Required]
    [StringLength(100, ErrorMessage = "Описание слишком длинное")]
    [MinLength(5, ErrorMessage = "Описание слишком короткое")]
    public string Description { get; set; }


    /// <summary>
    /// Дата и время созданиия поста
    /// </summary>

    [Required]
    public DateTime CreationDate { get; set; }

    
}