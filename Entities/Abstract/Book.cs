using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Enums;

namespace Entities.Abstract;

public abstract class Book : Entity<Guid>
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationYear { get; set; }
    public BookStatus Status { get; set; }
    public Guid LibraryId { get; set; }


    public Library? Library { get; set; } = null;

}
