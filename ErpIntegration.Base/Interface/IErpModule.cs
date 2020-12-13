using System.Collections.Generic;

namespace ErpIntegration.Base.Interface
{
    public interface IErpModule<TModuleObject> where TModuleObject : IModuleObject
    {
        bool Add(TModuleObject moduleObject);
        TModuleObject GetById(object id);
        string GetLastError();

        //TModuleObject Get(string code);
        //IEnumerable<TModuleObject> SearchByCode(string code);
        //object GetId(string code);
        //bool Exist(string code);
    }

}
