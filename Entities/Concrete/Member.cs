using Core.Entities;
using Core.Entities.Concrete;
using Entities.Abstract;

namespace Entities.Concrete;

public class Member : User, IMember
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public ICollection<Book> BorrowedBooks { get; set; }
}
