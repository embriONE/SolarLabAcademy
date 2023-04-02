using System.ComponentModel.DataAnnotations;

namespace Board.Contracts.Attributes;

public class NameValidationAttribute : ValidationAttribute
{

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        string? valueAsString = (string)value;
        
        var service = (IBadWordsService)validationContext.GetService(typeof(IBadWordsService));
        
        var badWords = service.GetBadWords();

        return badWords.Contains(valueAsString) 
            ? new ValidationResult("В наименовании содержатся запреенные слова") 
            : ValidationResult.Success;
    }
}