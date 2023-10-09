namespace ToDoList.Models
{
  public class ItemTag
    {   // primary key
        public int ItemTagId { get; set; }

        public int ItemId { get; set; }
        // reference navigation property #1
        public Item Item { get; set; }
        public int TagId { get; set; }
        // reference navigation property #2
        public Tag Tag { get; set; }
    }
}