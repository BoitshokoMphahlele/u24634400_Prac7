using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24634400_Prac7.Models
{
    public class Article : Publication
    {
        public Article(string Type,string title, Author author, string summary, string moreInfoUrl, DateTime publishDate,string image)
            : base(Type, title, author, summary, moreInfoUrl, publishDate,image)
        {

        }

        

        public string DisplayDate()
        {
            return PublishDate.ToString("dddd, dd MMMM yyyy");
        }

    }
}