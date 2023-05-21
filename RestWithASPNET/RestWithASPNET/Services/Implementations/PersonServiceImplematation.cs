using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplematation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }


            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = i,
                FirstName = "Person Teste" + i,
                LastName = "Person Teste" + i,
                Address = "Person Teste" + i,
                Gender = "Male"
            };
        }

        public Person FindBy(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Tiago Victor",
                LastName = "de Oliveira",
                Address = "Ribeirão Preto - São Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
