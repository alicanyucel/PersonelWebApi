using PersonelWebApi.Dros;
using PersonelWebApi.Model;

namespace PersonelWebApi.Services
{
    public sealed class PersonelService(
     IPersonelRepository personelRepository) : IPersonelService
    {
        public bool Create(CreatePersonelDto request)
        {
            bool isPersonelExists = personelRepository.IsPersonelExists(request.FirstName, request.LastName);

            if (isPersonelExists)
            {
                throw new ArgumentException("Personel already exists");
            }

            Personel personel = new Personel()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                StartingDate = request.StartingDate,
            };

            var result = personelRepository.Create(personel);
            return result;
        }

        public List<Personel> GetAll()
        {
            return personelRepository.GetAll();
        }
    }
}