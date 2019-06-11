using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using A100_AspNetCore.Services.API._DBService;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.VikService
{
    public class VikService : IVikService
    {
        public byte[] DownLoadVIKPhoto(int rid, int idVik)
        {
            throw new NotImplementedException();
        }

        // GET - метод, который получает VIK по ResoultID
        public Task<List<v_GetVik>> GetVik(int ResoultID)
        {
            return MyDB.db.v_GetVik.Where(i => i.ResoultID == ResoultID).ToListAsync();
        }

        // GET - метод, который получает названия VIK
        public Task<List<VikElement>> GetVikNames()
        {
            return MyDB.db.VikElement.ToListAsync();
        }

        public Task<List<byte[]>> GetVIKPhotoList(int idVik)
        {
            throw new NotImplementedException();
        }
    }
}
