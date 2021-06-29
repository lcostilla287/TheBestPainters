using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services
{
    public class MaterialService
    {
        private readonly Guid _userId;

        public MaterialService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateMaterial(MaterialCreate model)
        {
            var entity =
                new Material()
                {
                    OwnerId = _userId,
                    MaterialName = model.MaterialName,
                    Price = model.Price,
                    Quantity = model.Quantity,
                    JobId = model.JobId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Materials.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MaterialListItem> GetMaterials()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Materials
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new MaterialListItem
                            {
                                MaterialId = e.MaterialId,
                                JobId = e.JobId,
                                Quantity = e.Quantity
                            }
                        );
                return query.ToArray();
            }
        }

        public MaterialDetail GetMaterialById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Materials
                        .Single(e => e.MaterialId == id && e.OwnerId == _userId);
                return
                    new MaterialDetail
                    {
                        MaterialId = entity.MaterialId,
                        JobId = entity.JobId,
                        MaterialName = entity.MaterialName,
                        Price = entity.Price,
                        Quantity = entity.Quantity,
                        TotalPrice = entity.TotalPrice
                    };
            }
        }

        public bool UpdateMaterial(MaterialEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Materials
                        .Single(e => e.MaterialId == model.MaterialId && e.OwnerId == _userId);

                entity.MaterialName = model.MaterialName;
                entity.JobId = model.JobId;
                entity.Price = model.Price;
                entity.Quantity = model.Quantity;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteMaterial(int materialId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Materials
                        .Single(e => e.MaterialId == materialId && e.OwnerId == _userId);

                ctx.Materials.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
