using System;
using AspNetCoreTemplate.Data.Common.Models;

namespace AspNetCoreTemplate.Data.Models.System
{
    public class DatabaseVersions : DomainObject
    {
        public static readonly string Key = "508E9656-08D6-4D4C-AC4F-72086576FB28";

        public virtual string Name { get; set; }

        public virtual DateTime Released { get; set; }

        public virtual DateTime Updated { get; set; }

        public virtual string Comments { get; set; }

        public virtual bool NeedUpdate { get; set; }
    }
}
