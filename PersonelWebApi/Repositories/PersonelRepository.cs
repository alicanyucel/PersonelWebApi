using PersonelWebApi.Context;
using PersonelWebApi.Model;

namespace PersonelWebApi.Repositories
{
    public sealed class PersonelRepository(ApplicationDbContext context) : IPersonelRepository
    {
        public List<Personel> GetAll()
        {
            var personels = context.Personels.ToList();
            return personels;
        }

        public bool Create(Personel personel)
        {
            context.Add(personel);
            var result = context.SaveChanges();

            return (result > 0);
        }

        public bool IsPersonelExists(string firstName, string lastName)
        {
            bool result = context.Personels.Any(p => p.FirstName == firstName && p.LastName == lastName);
            return result;
        }
    }
}