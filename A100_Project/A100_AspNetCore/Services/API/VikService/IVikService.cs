using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API.VikService
{
    public interface IVikService
    {
        // GET - метод, который получает VIK по ResoultID
        Task<List<v_GetVik>> GetVik(int ResoultID);

        // GET - метод, который получает названия VIK
        Task<List<VikElement>> GetVikNames();

        // GET - метод, который получает список фото повреждений, имеющихся на сервере
        Task<List<byte[]>> GetVIKPhotoList(int idVik);

        // POST - метод, который загружает фото повреждения с сервера на устройство
        byte[] DownLoadVIKPhoto(int rid, int idVik);
    }
}
