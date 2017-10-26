using System;
using AspNetCoreTemplate.Data.Common.Models;

namespace Krista.FM.Domain
{
    public class AppliedAlters : BaseModel<int>
    {
        public static readonly string Key = "D08900D8-161A-4A7D-9650-F4AF88183342";

        public virtual string AlterName { get; set; }

        public virtual DateTime AppliedAt { get; set; }

        public virtual string Note { get; set; }
    }
}