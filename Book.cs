
namespace MiniProjectUser
{
    internal class Book
    {
        public string BookName { get; set; }
        public int PageCount { get; set; }


        public Book(string BookName,int PageCount)
        {
            this.BookName = BookName;
            this.PageCount = PageCount;

        }
    }
}
