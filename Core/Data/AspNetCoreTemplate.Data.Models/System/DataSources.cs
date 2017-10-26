using AspNetCoreTemplate.Data.Common.Models;

namespace Krista.FM.Domain
{
    public class DataSources : DomainObject
    {
        public virtual string SupplierCode { get; set; }

        public virtual int DataCode { get; set; }

        public virtual string DataName { get; set; }

        public virtual int KindsOfParams { get; set; }

        public virtual string Name { get; set; }

        public virtual int Year { get; set; }

        public virtual int Month { get; set; }

        public virtual string Variant { get; set; }

        public virtual int Quarter { get; set; }

        public virtual string Territory { get; set; }

        public virtual int Locked { get; set; }

        public virtual int Deleted { get; set; }

        public virtual int Confirmed { get; set; }

        public virtual string DataSourceName { get; set; }
    }
}
