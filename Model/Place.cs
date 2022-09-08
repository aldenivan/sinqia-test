using System.ComponentModel.DataAnnotations;

namespace SinqiaTest.Model
{


    public class Place
    {
        #pragma warning disable CS8618
        [Key]
        public int Id { get; set; }

        public string Name { get; set ; }

        public string Description { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public DateTime Date { get; set; }
    }
}