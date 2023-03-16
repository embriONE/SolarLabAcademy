namespace Board.Contracts.Posts;

/// <summary>
/// Модель создания объявления
/// </summary>

public class CreatePostDto
{
    
    /// <summary>
    /// Название поста
    /// </summary>
    public string Name { get; set; }

    
    /// <summary>
    /// Описание поста
    /// </summary>
    public string Description { get; set; }

    
    /// <summary>
    /// Дата и время созданиия поста
    /// </summary>
    public DateTime CreationDate { get; set; }
}