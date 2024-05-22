using PersonelWebApi.Context;
using PersonelWebApi.Model;

namespace PersonelWebApi.Repositories
{
    public sealed class PersonelRepository(ApplicationDbContext context)
    {
        public List<Personel> GetAll()
        {
            var personels=context.Personels.ToList();
            return personels;
        }
        public bool Create(Personel personel)
        { 
            context.Add(personel);
            var result=context.SaveChanges();
            return result > 0;
        }
    }
}
public interface IPersonelRepository
{
    List<Personel> GetAll();
    bool Create(Personel personel);
}