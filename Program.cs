using MiniProjectUser;


Book[] Books = new Book[10];
for(int i = 0; i < Books.Length; i++)
{
    Console.WriteLine("Book's name:");
    string BookName = Console.ReadLine();
    Console.WriteLine("Page of the book:");
    int PageCount = int.Parse(Console.ReadLine());


    while (!(CheckName(BookName)))
    {
        Console.WriteLine("Adi duzgun daxil edin:");
        BookName = Console.ReadLine();
    }
    while (!(CheckCount(PageCount)))
    {
        Console.WriteLine("Reqemi duzgun daxil edin:");
        PageCount = int.Parse(Console.ReadLine());
    }

    while (!(Search(BookName)))
    {

        Console.WriteLine("Eyni adda kitab daxil etmek olmaz");
        BookName = Console.ReadLine();
    }

    Book Book = new Book(BookName, PageCount);
    Books[i] = Book;
}

bool CheckName(string BookName)
{
    if (BookName.Length >= 3 && !string.IsNullOrWhiteSpace(BookName))
    {
        return true;
    }
    return false;
    
}

bool CheckCount(int PageCount)
{
    if (PageCount >= 10) { return true; }
    return false;
}

bool Search(string name)
{
    for(int i = 0; i < Books.Length; i++)
    {
        if(Books[i] != null)
        {
            if (name==Books[i].BookName)
            {
                return false;
            }
        }
    }
    return true;
}

foreach (Book book in Books)
{
    Console.WriteLine($"Name: {book.BookName} ; PageCount: {book.PageCount}");
}