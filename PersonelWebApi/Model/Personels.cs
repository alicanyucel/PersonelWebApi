namespace PersonelWebApi.Model
{
    public sealed class Personel
    {
        public Personel()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly StartingDate { get; set; }
    }
}