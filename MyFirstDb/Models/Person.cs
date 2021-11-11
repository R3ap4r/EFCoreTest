using System.Collections.Generic;


namespace MyFirstDb.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Adress> Adresses { get; set; }
    }
    public class Adress
    {
        public int? Id { get; set; }
        public string StreetName { get; set; }
        public int Number { get; set; }
        public int? Bus { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsMain { get; set; }
    }
}