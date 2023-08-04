using Sb.Entities;

namespace Sb {
    internal class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Have a nice a trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("03/06/2018 13:05:44"),
                "Traveling to New Zealeand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c3);
            Console.WriteLine(p1);
        }
    }
}