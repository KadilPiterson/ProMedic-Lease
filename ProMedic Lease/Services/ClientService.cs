using ProMedic_Lease.DataAccess.Repositories;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Add(Client client)
        {
            _clientRepository.Add(client);
        }

        public Client GetById(long id)
        {
            return _clientRepository.GetById(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public void Update(Client client)
        {
            _clientRepository.Update(client);
        }

        public void Delete(long id)
        {
            _clientRepository.Delete(id);
        }

        public IEnumerable<Client> GetAllActive()
        {
            return _clientRepository.GetAll().Where(e => e.IsActive).ToList();
        }

        public IEnumerable<Client> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _clientRepository.GetAll()
                .Where(e => e.FirstName.ToLower().Contains(searchTerm) ||
                            e.LastName.ToLower().Contains(searchTerm) ||
                            e.Email.ToLower().Contains(searchTerm) ||
                            e.Phone.ToLower().Contains(searchTerm) ||
                            e.Street.ToLower().Contains(searchTerm) ||
                            e.City.ToLower().Contains(searchTerm) ||
                            e.PostalCode.ToLower().Contains(searchTerm))
                .ToList();
        }
    }
}
