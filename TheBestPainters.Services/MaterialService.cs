using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services.MaterialResponsibilities;

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
            var entity = MaterialDataCapture.Capture(model, _userId);

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
                var query = MaterialQuery.Query(ctx, _userId);
                    
                return query.ToArray();
            }
        }

        public MaterialDetail GetMaterialById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindMaterial.GetMaterial(ctx, id, _userId);

                return ReturnMaterialData.MaterialData(entity);
            }
        }

        public bool UpdateMaterial(MaterialEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindMaterial.GetMaterial(ctx, model.MaterialId, _userId);

                MaterialUpdate.Update(model, entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteMaterial(int materialId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindMaterial.GetMaterial(ctx, materialId, _userId);

                ctx.Materials.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
