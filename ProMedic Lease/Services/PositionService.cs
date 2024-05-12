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
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public void Add(Position position)
        {
            _positionRepository.Add(position);
        }

        public Position GetById(long id)
        {
            return _positionRepository.GetById(id);
        }

        public IEnumerable<Position> GetAll()
        {
            return _positionRepository.GetAll();
        }

        public void Update(Position position)
        {
            _positionRepository.Update(position);
        }

        public void Delete(long id)
        {
            _positionRepository.Delete(id);
        }

        public IEnumerable<Position> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _positionRepository.GetAll()
                .Where(e => e.Name.ToLower().Contains(searchTerm))
                .ToList();
        }

        public Position PrepareForUpdate(Position entity, string name)
        {
            entity.Name = name;

            return entity;
        }

        public Position CreateFormData(string name)
        {
            return new Position
            {
                Name = name
            };
        }
    }
}
