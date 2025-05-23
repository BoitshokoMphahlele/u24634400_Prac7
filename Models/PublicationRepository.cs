using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace u24634400_Prac7.Models
{
    public class PublicationRepository
    {
        public static List<Publication> GetAllPublications()
        {
            var author1 = new Author("Koffi", "Umukoro");
            var author2 = new Author("Octavia", "Barret");
            var author3 = new Author("Gunnhild", "Aric");
            var author4 = new Author("Jakob", "Ayanda");
            var author5 = new Author("Shyam", "Benson");
            var author6 = new Author("Lucas", "Asim");
            var author7 = new Author("Harmon", "Deeann");
            var author8 = new Author("Gargi", "Sudheer");


            return new List<Publication>
            {
                new Article( "Article","Improving the foundation of our falling sand simulator",author1,"Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. " +
                            "However, Addison manages to rescue the situation by buying a magnificent t-shirt.","https://bait.example.net/bag.aspx",new DateTime(2018, 7, 24),"https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg"),

                new Book("Book","NASA fed some Apollo 11 lunar samples to cockroaches and mice",author2,"A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor." +
                         "However, her chances are scuppered when her son goes missing." +
                         "Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.","https://www.example.com/bite.aspx",new DateTime(2006, 5, 15),2,"https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg"),

                new Article("Article","When Your Smart ID Card Reader Comes with Malware",author3,"A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor." +
                            " However, her chances are scuppered by an angyy camel. " +
                            "After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.","https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",new DateTime(2023, 3, 21),
                            "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg"),

                new Book ("Book","Jailer: A truly relational database tool",author4,"In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by killing his own ex-wife." +
                          " Eventually, the golfer forms an army and teaches the robots a little respect.","https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",new DateTime(1989, 6, 6),3,
                          "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg"),

                new Article("Article","Everything you ever wanted to know about terminal",author5,"In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the goverment by killing her own step-sister. " +
                            "It turns out all the robots were a manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.","https://www.example.com/bait/bath.php",new DateTime(2020, 1, 23),
                            "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg"),

                new Article("Article","NaturalSpeech: End-to-end text to speech synthesis with human-level quality",author6,"When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a deralict castle. " +
                            "Eventually, the movie star realises that she has always been a worthwhile person and does not need to change.","http://www.example.com/bear",new DateTime(2022, 10, 28),
                            "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png"),

                new Article("Article","Husky, Datadog's Third-Generation Event Store",author7,"A WW2 veteran Brisbane who recieves an invitation to a modern battle. " +
                            "It turns out the invitations is spam and is from a scammer who is famous for making up stories.","https://www.example.com/bells", new DateTime(2023, 3, 4),
                            "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg"),

                new Book("Book","Singers and Vampires",author8,"In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring." +
                         " It turns out the vampires are all sheep.","https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",new DateTime(1972, 4, 24),2,
                         "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg")




            };
        }
    }
}