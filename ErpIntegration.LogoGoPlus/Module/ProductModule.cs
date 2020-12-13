using ErpIntegration.Base.Interface;
using ErpIntegration.Base.ModuleObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpIntegration.LogoGoPlus.Module
{
    public class ProductModule : IErpModule<ProductModuleObject>
    {
        public bool Add(ProductModuleObject moduleObject)
        {
            //unity dll ile eklendi
            return true;
        }

        public ProductModuleObject GetById(object id)
        {
            //unityden çekti
            return new ProductModuleObject
            {
                Barcode = "kasldkjaksldj",
                Code = "asşdas",
                Name ="asdasjd"
            };
        }

        public string GetLastError()
        {
            throw new NotImplementedException();
        }
    }
}
