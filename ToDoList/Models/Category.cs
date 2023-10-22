using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Category 
  {
    
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "Categories must have a name.")]
    public string Name { get; set; }
    public List<Item> Items { get; set; }
  }
}