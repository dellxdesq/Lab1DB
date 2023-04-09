namespace laba1;
class Program
{
    public static void Main()
    {
        History history = new History();

        Book book1 = new Book("buratino", "misha", 2023, 12, 50);
        Book book2 = new Book("buratinich", "father mishi", 2024, 13, 49);
        Book book3 = new Book("buratinka", "mother mishi", 2049, 10, 51);

        Customer customer1 = new Customer("misha", 229);
        Customer customer2 = new Customer("michail", 3123);

        history.AddNote(customer1, book1, new DateTime(123), OperationType.Return);
        history.AddNote(customer2, book2, new DateTime(324), OperationType.Return);
        history.AddNote(customer1, book3, new DateTime(543), OperationType.Take);

        history.Print();
    }
}
