using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Entities;
public class Book
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Author { get; set; }
    public string? Description { get; set; }
    public required double Price { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\nBook: {Name}\nAuthor: {Author}\nDescription: {Description}\nPrice: {Price}";
    }
}
