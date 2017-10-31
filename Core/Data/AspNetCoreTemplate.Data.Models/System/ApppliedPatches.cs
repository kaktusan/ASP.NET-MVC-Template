using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCoreTemplate.Data.Common.Models;

namespace Krista.FM.Domain
{
    public class ApppliedPatches : DomainObject
    {
        public static readonly string Key = "9A5480F1-34D6-402F-8DEF-3A857814C732";

        public virtual string PatchName { get; set; }

        public virtual DateTime AppliedAt { get; set; }

        public virtual string Note { get; set; }
    }
}