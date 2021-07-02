using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class NullMaterials
    {
        public static void Nullify(Job entity)
        {
            foreach (var material in entity.Materials)
            {
                material.JobId = null;
            }
        }
    }
}
