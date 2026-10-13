using Library;


List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "Bill Gates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));
members.Add(new Member(2323,"MR Darcy", "Jane Auston", 7394648));
members.Add(new Member(2, "Miss Elisabeth Bennet", "Jane Auston", 8488847));
books[0].DisplayInfo();
foreach(Book book in books)
{
   book.DisplayInfo();
  

}

foreach (Member member in members)
{
    member.DisplayInfo();


}


// This is another book in our library



// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class


Console.WriteLine("Current library members");


