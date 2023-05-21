using RestWithASPNET.Model;

namespace RestWithASPNET.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindBy(long id);
        void Delete(long id);
        Person Update(Person person);
        List<Person> FindAll();
    }
}
