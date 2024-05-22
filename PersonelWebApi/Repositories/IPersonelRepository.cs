using PersonelWebApi.Model;

public interface IPersonelRepository
{
    List<Personel> GetAll();
    bool Create(Personel personel);
}