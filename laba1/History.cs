using System.Diagnostics.CodeAnalysis;
using System.Globalization;
namespace laba1;
public class History
{
    public History()
    {
        Persons = new List<Customer?>();
        Books = new List<Book?>();
        Times = new List<DateTime?>();
        Types = new List<OperationType?>();

    }

    public List<Customer?> Persons { get; set; }
    public List<Book?> Books { get; set; }
    public List<DateTime?> Times { get; set; }
    public List<OperationType?> Types;


    public void AddNote(Customer customer, Book book, DateTime time, OperationType type)
    {
        Persons.Add(customer);
        Books.Add(book);
        Times.Add(time);
        Types.Add(type);
    }

    public void Print()
    {
        for (int i = 0; i < Persons.Count; i++)
        {
            Console.WriteLine(Persons[i].Name + " " + Books[i].Name + " " + Times[i] + " " + Types[i]);
        }
        
    }
}
