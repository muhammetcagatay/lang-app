

using AutoMapper;
using System.Text;
using System.Text.Json;
using System.Web.Helpers;
using User.Service.Models.Dtos;
using User.Service.Models.Entities;

namespace User.Service.Services
{
    public interface IUserService
    {
        public PersonDto.GetDto GetByEmail(string email);
        public PersonDto.GetDto GetById(int id);
        public void Create(PersonDto.CreateDto createDto);
        public void Update(int id, PersonDto.UpdateDto updateDto);
        public void Delete(int id);
    }
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserDBContext _context;
        public UserService(UserDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public PersonDto.GetDto GetByEmail(string email)
        {
            var person = _context.People.Where(x => x.Email == email && !x.IsDelete).FirstOrDefault();

            var personDto = _mapper.Map<PersonDto.GetDto>(person);

            return personDto;
        }
        public PersonDto.GetDto GetById(int id)
        {
            var person = _context.People.Where(x => x.Id == id && !x.IsDelete).FirstOrDefault();

            var personDto = _mapper.Map<PersonDto.GetDto>(person);

            return personDto;
        }
        public void Create(PersonDto.CreateDto createDto)
        {
            var person = _mapper.Map<Person>(createDto);
            person.Password = HashPassword(createDto.Password);

            if(!_context.People.Any(x => x.Email == person.Email && x.IsDelete == false))
            {
                using var httpClient = new HttpClient();

                httpClient.BaseAddress = new Uri("http://authservice:80/");

                PersonDto.RequestDto product = new PersonDto.RequestDto()
                {
                    Email = person.Email,
                    Password = createDto.Password,
                };

                var serializeProduct = JsonSerializer.Serialize(product);

                StringContent stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

                var result = httpClient.PostAsync("api/auth/create", stringContent).Result;

                _context.People.Add(person);
                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var person = _context.People.Where(x => x.Id == id && !x.IsDelete).FirstOrDefault();

            if (person != null)
            {
                person.IsDelete = true;
                _context.SaveChanges();
            }
        }
        public void Update(int id, PersonDto.UpdateDto updateDto)
        {
            var personHas = _context.People.Where(x => x.Email==updateDto.Email && !x.IsDelete).FirstOrDefault();

            if(personHas!=null)
            {
                if(personHas.Id != id)
                {
                    return;
                }
            }

            var person = _context.People.Where(x => x.Id == id && !x.IsDelete).FirstOrDefault();

            if (person != null)
            {
                person.FirstName= updateDto.FirstName;
                person.LastName= updateDto.LastName;
                person.MiddleName= updateDto.MiddleName;
                person.Age = updateDto.Age;
                person.City= updateDto.City;
                person.Country= updateDto.Country;
                person.Email= updateDto.Email;
                person.Password= HashPassword(updateDto.Password);
                person.UpdatedDate = DateTime.Now;

                _context.SaveChanges();
            }
        }
        private string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }
    }
}
