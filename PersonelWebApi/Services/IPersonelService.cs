using PersonelWebApi.Dros;
using PersonelWebApi.Model;

namespace PersonelWebApi.Services
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        bool Create(CreatePersonelDto request);
    }
    public sealed class PersonelService(IPersonelRepository personelRepository) : IPersonelService
    {
        public bool Create(CreatePersonelDto request)
        {
        
        }

        public List<Personel> GetAll()
        {
          
        }
    }
}
