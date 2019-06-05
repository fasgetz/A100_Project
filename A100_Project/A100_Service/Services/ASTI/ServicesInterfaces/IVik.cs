using A100_Service.DataBase.ASTI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.ServicesInterfaces
{
    [ServiceContract]
    interface IVik
    {
        // GET - метод, который получает VIK по ResoultID
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetProjectVIK?token={token}&id={ResoultID}")]
        List<v_GetVik> GetVik(string token, int ResoultID);

        // GET - метод, который получает названия VIK
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetVikNames?token={token}")]
        List<VikElement> GetVikNames(string token);

        // GET - метод, который получает список фото повреждений, имеющихся на сервере
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetVIKPhotoList?token={token}&idVik={idVik}")]
        List<byte[]> GetVIKPhotoList(string token, int idVik);

        // GET - метод, который загрузка фото повреждения с сервера на устройство
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "DownLoadVIKPhoto?token={token}&rid={rid}&idVik={idVik}")]
        byte[] DownLoadVIKPhoto(string token, int rid, int idVik);
    }
}
