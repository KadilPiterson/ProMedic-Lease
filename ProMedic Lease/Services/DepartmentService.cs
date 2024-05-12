using ProMedic_Lease.DataAccess.Repositories;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProMedic_Lease.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Add(Department department)
        {
            _departmentRepository.Add(department);
        }

        public Department GetById(long id)
        {
            return _departmentRepository.GetById(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public void Update(Department department)
        {
            _departmentRepository.Update(department);
        }

        public void Delete(long id)
        {
            _departmentRepository.Delete(id);
        }

        public IEnumerable<Department> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _departmentRepository.GetAll()
                .Where(e => e.Name.ToLower().Contains(searchTerm))
                .ToList();
        }

        public Department PrepareForUpdate(Department entity, string name)
        {
            entity.Name = name;

            return entity;
        }

        public Department CreateFormData(string name)
        {
            return new Department
            {
                Name = name
            };
        }
    }
}
