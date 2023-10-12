using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; 
    set; }
    [Required(ErrorMessage = "Item must have description: please add a description.")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. If none have been created, do so now.")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; set; }
  }
}