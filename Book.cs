using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhucHN3
{
    internal class Book
    {
        private string title;
        private string author;

        public string Title { 
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty or whitespace.");
                }
                title = value;
            } 
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString() => $"Title: {Title}, Author: {Author}";
    }
}
