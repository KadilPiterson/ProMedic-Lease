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

        public void AddClient(Client client)
        {
            _clientRepository.AddClient(client);
        }

        public Client GetClientById(long id)
        {
            return _clientRepository.GetClientById(id);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAllClients();
        }

        public void UpdateClient(Client client)
        {
            _clientRepository.UpdateClient(client);
        }

        public void DeleteClient(long id)
        {
            _clientRepository.DeleteClient(id);
        }
    }
}
