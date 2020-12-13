namespace ErpIntegration.Base.Interface
{
    public interface IErpService
    {
        string ErpName { get; set; }
        IErpModule<ModuleObject.CustomerModuleObject> CustomerModule { get; set; }
        IErpModule<ModuleObject.ProductModuleObject> ProductModule { get; set; }
        IErpModule<ModuleObject.DocumentModuleObject> InvoiceModule { get; set; }
        IErpModule<ModuleObject.DocumentModuleObject> DespatchModule { get; set; }

        //...

    }

}
