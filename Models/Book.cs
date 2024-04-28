using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

public class Book
{
    public int? Id { get; set; }

    [Required]
    public string? Title { get; set; }
    public Author? Author { get; set; }
}

