using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public  class Book : IEquatable<Book> 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public string Placemant { get; set; }
        public string Category { get; set; }
        public string IdLibrary { get; set; }

        public  bool Equals(Book? other)
        {
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;

            return Title == other.Title;
        }
        public override int GetHashCode()
        {
            int hashProductName = Title == null ? 0 : Title.GetHashCode();

            int hashProductCode = Title.GetHashCode();

            return hashProductName ^ hashProductCode;
        }


        public override string ToString()
        {
            return Title+ ", "+ Author+ " ,pages: "+NumberOfPages +" ,category: "+Category ;
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
