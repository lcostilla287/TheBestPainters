using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services
{
    public class EmployeeService
    {
        private readonly Guid _userId;

        public EmployeeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateEmployee(EmployeeCreate model)
        {
            var entity =
                new Employee()
                {
                    OwnerId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CrewId = model.CrewId,
                    StreetAddress = model.StreetAddress,
                    CityAddress = model.CityAddress,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    IsCrewChief = model.IsCrewChief
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<EmployeeListItem> GetEmployees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Employees
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new EmployeeListItem
                            {
                                Id = e.Id,
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                CrewId = e.CrewId,
                                IsCrewChief = e.IsCrewChief
                            }
                        );
                return query.ToArray();
            }
        }

        public EmployeeDetail GetEmployeeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.Id == id && e.OwnerId == _userId);

                return
                    new EmployeeDetail
                    {
                        Id = entity.Id,
                        CrewId = entity.CrewId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        StreetAddress = entity.StreetAddress,
                        CityAddress = entity.CityAddress,
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        IsCrewChief = entity.IsCrewChief
                    };
            }
        }

        public bool UpdateEmployee(EmployeeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Employees
                    .Single(e => e.Id == model.Id && e.OwnerId == _userId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.StreetAddress = model.StreetAddress;
                entity.CityAddress = model.CityAddress;
                entity.CrewId = model.CrewId;
                entity.PhoneNumber = model.PhoneNumber;
                entity.Email = model.Email;
                entity.IsCrewChief = model.IsCrewChief;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.Id == employeeId && e.OwnerId == _userId);

                ctx.Employees.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
