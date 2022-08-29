using DndBlazorApp.Models;

namespace DndBlazorApp.Data;

public class DndApiIndexResult
{
    public int Count { get; set; }
    public ICollection<DndApiReference>? Results { get; set; }
}