using System.ComponentModel.DataAnnotations;

namespace MyApp1.Models
{
    public class Address
    {
        public virtual int Id { get; set; }

        public virtual string Line1 { get; set; }

        public virtual string Line2 { get; set; }

        public virtual string City { get; set; }

        public virtual string state { get; set; }

        public virtual string ZipCode { get; set; }
    }
}
