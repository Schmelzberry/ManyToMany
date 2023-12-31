using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public bool Complete { get; set; }
    public Category Category { get; set; }
    // collection navigation property
    public List<ItemTag> JoinEntities { get;}
  }
}