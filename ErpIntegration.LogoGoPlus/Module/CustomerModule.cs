using ErpIntegration.Base;
using ErpIntegration.Base.Interface;
using ErpIntegration.Base.ModuleObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpIntegration.LogoGoPlus.Module
{
    public class CustomerModule : IErpModule<CustomerModuleObject>
    {
        private readonly ErpService erpService;
        private string lastError = string.Empty;

        public CustomerModule(ErpService erpService)
        {
            this.erpService = erpService;
        }

        public bool Add(CustomerModuleObject moduleObject)
        {

            

            //firma numarası
            //db connection stir
            //server adı

            //unity dll ile eklendi

            //hata çıkarsa 
            /*
            lastError = "hata oluştu : " + unityDll.hatakodu;
            return false;
            */

            return true;
        }

        public CustomerModuleObject GetById(object id)
        {
            //unityden çekti
            return new CustomerModuleObject
            {
                Code = "cari kod",
                TaxNumber = "vergi no",
                Title = "ünvan"
            };
        }

        public string GetLastError()
        {
            return lastError;
        }
    }
}
