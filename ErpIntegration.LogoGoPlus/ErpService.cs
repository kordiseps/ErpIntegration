using ErpIntegration.Base;
using ErpIntegration.Base.Interface;
using ErpIntegration.Base.ModuleObject;
using ErpIntegration.LogoGoPlus.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpIntegration.LogoGoPlus
{
    public class ErpService : IErpService
    {
        public IErpModule<CustomerModuleObject> CustomerModule { get; set; }
        public IErpModule<ProductModuleObject> ProductModule { get; set; }
        public IErpModule<DocumentModuleObject> InvoiceModule { get; set; }
        public IErpModule<DocumentModuleObject> DespatchModule { get; set; }
        public string ErpName { get; set; }

        public ErpService()
        {
            ErpName = "LogoGoPlus";
            CustomerModule = new CustomerModule(this);
            ProductModule = new ProductModule();
            InvoiceModule = null;
            DespatchModule = null;
        }
    }
}
