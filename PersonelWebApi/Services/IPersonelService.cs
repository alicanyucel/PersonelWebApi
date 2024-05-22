using PersonelWebApi.Dros;
using PersonelWebApi.Model;

namespace PersonelWebApi.Services
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        bool Create(CreatePersonelDto request);
    }
}
