namespace Bookify.Application.Behavior;

public record ValidationError(string PropertyName, string ErrorMessage);