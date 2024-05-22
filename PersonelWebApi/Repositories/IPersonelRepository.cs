using PersonelWebApi.Model;

public interface IPersonelRepository
{
    List<Personel> GetAll();
    bool Create(Personel personel);
    bool IsPersonelExists(string firstName, string lastName);
}