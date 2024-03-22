using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IClientService
    {
        void AddClient(Client client);
        Client GetClientById(long id);
        IEnumerable<Client> GetAllClients();
        void UpdateClient(Client client);
        void DeleteClient(long id);
    }
}
