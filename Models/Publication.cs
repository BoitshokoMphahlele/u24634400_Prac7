using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24634400_Prac7.Models
{
    public class Publication
    {
            public string _type { get; set; }
            public string Title { get; set; }
            public Author Author { get; set; }
            public string Summary { get;  set; }
            public string MoreInfoUrl { get; set; }
            public DateTime PublishDate { get; set; }
            public string ImageUrl { get; set; }

        public Publication(string Type,string title, Author author, string summary, string moreInfoUrl, DateTime publishDate,string image)
        {
                _type = Type;
                Title = title;
                Author = author;
                Summary = summary;
                MoreInfoUrl = moreInfoUrl;
                PublishDate = publishDate;
                ImageUrl = image;
        }

            

        
            
        
    }
}
