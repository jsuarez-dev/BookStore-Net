namespace BookStore.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class AuthorModel
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}
