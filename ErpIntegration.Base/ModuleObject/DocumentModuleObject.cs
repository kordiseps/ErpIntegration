namespace ErpIntegration.Base.ModuleObject
{
    public class DocumentModuleObject : Interface.IModuleObject
    {
        public DocumentHeader DocumentHeader { get; set; }
        public System.Collections.Generic.List<DocumentLine> DocumentLines { get; set; }
    }
    public class DocumentHeader
    {
        public string DocumentNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string CustomerCode { get; set; }
        public string CurrencyCode { get; set; }

        //..

    }
    public class DocumentLine
    {
        public short LineNumber { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UnitCode { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }

        //..
    }

}
