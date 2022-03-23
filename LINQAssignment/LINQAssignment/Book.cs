using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public  class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public string Placemant { get; set; }
        public string Category { get; set; }
        public string IdLibrary { get; set; }

        public override string ToString()
        {
            return $"{Title} {(Author != null ? "written by " + Author : "")}.{(Category!=null ? "The Category is "+Category :"")}";
        }
    }
    public class ChildrenBook : Book
    {
        public bool ColoringBook { get; set; }
    }
    public  class Library
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List <Book> Books { get; set; }
    }
}
