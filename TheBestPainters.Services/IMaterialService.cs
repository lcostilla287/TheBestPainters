using System.Collections.Generic;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services
{
    public interface IMaterialService
    {
        bool CreateMaterial(MaterialCreate model);
        bool DeleteMaterial(int materialId);
        MaterialDetail GetMaterialById(int id);
        IEnumerable<MaterialListItem> GetMaterials();
        bool UpdateMaterial(MaterialEdit model);
    }
}