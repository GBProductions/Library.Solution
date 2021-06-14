using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<AuthorBook>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public int PatronId {get;set;}
    public virtual Patron Patron {get;set;}

    public virtual ApplicationUser User { get; set; } //new line

    public virtual ICollection<AuthorBook> JoinEntities { get;}
  }
}