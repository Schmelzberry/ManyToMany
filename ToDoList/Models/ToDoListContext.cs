using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  { // creating entities so EF core knows how to update DB
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ItemTag> ItemTags { get; set; }
    // above is our join entity, which updates our join table
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
