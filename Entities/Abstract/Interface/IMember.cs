using Entities.Abstract;
using Entities.Enums;

namespace Core.Entities;

public interface IMember
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public ICollection<Book> BorrowedBooks { get; set; }

    public void BorrowABook(Book book)
    {
        if (book.Status == BookStatus.Available)
        {
            BorrowedBooks.Add(book);
            book.Status = BookStatus.Lended;
        }
        else
        {
            throw new Exception("Kitap ödünç alınabilir durumda değil.");
        }
    }
    public void ReturnABook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            book.Status = BookStatus.Available;
        }
    }
}
