using A100_Service.DataBase.ASTI;
using A100_Service.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Services.ASTI.BusinessLogic
{
    public static class ElementLogic
    {
        public static List<ElementsOfType> GetElementsOfType()
        {
            return new EFGenericRepository<ElementsOfType>(new DataBase.ASTI.ASTI()).GetAllList();
        }

        public static List<Element> GetElements()
        {
            return new EFGenericRepository<Element>(new DataBase.ASTI.ASTI()).GetAllList();
        }
    }
}
