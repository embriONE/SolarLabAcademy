using System.Text.Json.Serialization;
using Board.Application.Appdata.Posts.Services;
using Microsoft.AspNetCore.Mvc;
using Board.Contracts.Posts;
using Newtonsoft.Json;


namespace Board.Host.Api.Controllers;

/// <summary>
/// контроллер для работы с объявлениями
/// </summary>
[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    
    private readonly ILogger<PostsController> _logger;
    private readonly IPostService _postService;

    /// <summary>
    /// инициализация экземпляра <see cref="PostsController"/>
    /// </summary>
    /// <param name="logger">Сервис логирования</param>
    /// <param name="postService">Сервис для работы с объявлениями</param>
    public PostsController(ILogger<PostsController> logger, IPostService postService)
    {
        _logger = logger;
        _postService = postService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet("get-posts")]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation($"Запрос объявлений");
        return await Task.Run(Ok);
    }

    /// <summary>
    /// сохраняет новое объявление
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="cancellation">Токен отмены операции</param>
    /// <returns>модель созданного объявления</returns>
    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] CreatePostDto dto, CancellationToken cancellation)
    {
        _logger.LogInformation($"{JsonConvert.SerializeObject(dto)}");

        var result = _postService.AddPost(dto, cancellation);

        return await Task.Run(() => Created(string.Empty, null));
    } 
}