using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Services.EmployeeResponsibilities;

namespace TheBestPainters.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly Guid _userId;

        public EmployeeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateEmployee(EmployeeCreate model)
        {
            var entity = EmployeeDataCapture.Capture(model, _userId);

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add((Employee)entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<EmployeeListItem> GetEmployees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = EmployeeQuery.Query(ctx, _userId);

                return query.ToArray();
            }
        }

        public EmployeeDetail GetEmployeeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindEmployee.GetEmployee(ctx, id, _userId);

                return (EmployeeDetail)EmployeeData.Return(entity);
            }
        }

        public bool UpdateEmployee(EmployeeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindEmployee.GetEmployee(ctx, model.EmployeeId, _userId);

                EmployeeUpdate.Update(entity, model);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindEmployee.GetEmployee(ctx, employeeId, _userId);

                ctx.Employees.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
