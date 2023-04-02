using Board.Contracts;

namespace Board.Application.Appdata;

public class BadWordsService : IBadWordsService
{
    public string[] GetBadWords()
    {
        return new[]
        {
            "козявка",
            "каловик",
            "вульва"
        };
    }
}