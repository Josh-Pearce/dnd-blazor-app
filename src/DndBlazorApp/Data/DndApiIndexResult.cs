using DnD_BlazorApp.Models;

namespace DnD_BlazorApp.Data;

public class DndApiIndexResult
{
    public int Count { get; set; }
    public ICollection<DndApiReference>? Results { get; set; }
}