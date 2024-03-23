using Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete;

public class Library
{
    public Library()
    {
        
    }

    public ICollection<Book> Books { get; set; }
    public ICollection<Member> Members { get; set; }


    public void UpdateBookStatusToAvailable(Book book)
    {
        book.Status = BookStatus.Available;
    }
    public void UpdateBookStatusToLended(Book book)
    {
        book.Status = BookStatus.Lended;
    }
    public void UpdateBookStatusToNotAvailable(Book book)
    {
        book.Status = BookStatus.NotAvailable;
    }

    public void LendABook(Book book, Member member)
    {
        if (book.Status == BookStatus.Available)
        {
            member.BorrowedBooks.Add(book);
            book.Status = BookStatus.Lended;
        }
        else
        {
            throw new Exception("Kitap ödünç alınabilir durumda değil.");
        }
    }
    public void ReturnABook(Book book, Member member)
    {
        if (member.BorrowedBooks.Contains(book))
        {
            member.BorrowedBooks.Remove(book);
            book.Status = BookStatus.Available;
        }
    }
}
