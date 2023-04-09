namespace laba1;
public class Book
{
    public Book(string? name, string? author, int? yearPublished, uint? bookCase, uint? bookShelf)
    {      
        Name = name;
        Author = author;
        YearPublished = yearPublished;
        BookCase = bookCase;
        BookShelf = bookShelf;
    }

    public string? Name { get; set; }
    public string? Author { get; set; }
    public int? YearPublished { get; set; }
    public uint? BookCase { get; set; }
    public uint? BookShelf { get; set; }

}