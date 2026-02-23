namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);
        static void Main(string[] args)
        {
            Bookstore classic = new(001, "Moby Dick", "Abraham Shamis", 10.10);
            Bookstore greek = new(002, "Illiad", "Homer", 12.00);
            Bookstore comedy = new(003, "A Summer's night dream", "William Shakespear", 20.00);
            Console.WriteLine(classic + "\n" + greek + "\n" + comedy);
        }
    }
}
