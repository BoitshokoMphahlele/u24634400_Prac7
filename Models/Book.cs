using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24634400_Prac7.Models
{
    public class Book : Publication
    {
        public int Editions { get; private set; }

        public Book(string Type,string title,  Author author, string summary, string moreInfoUrl, DateTime publishDate, int editions,string image)
            : base(Type,title, author, summary, moreInfoUrl, publishDate, image)
        {
            Editions = editions;
        }

        public string DisplayEditions()
        {
            return $"{Editions} Edition(s)";
        }

        public string DisplayDate()
        {
            return PublishDate.ToString("dddd, dd MMMM yyyy");
        }


       




    }
}