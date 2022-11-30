namespace Dentiste.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Observation> Observations { get; set; }
        public int MyProperty { get; set; }
    }
}
