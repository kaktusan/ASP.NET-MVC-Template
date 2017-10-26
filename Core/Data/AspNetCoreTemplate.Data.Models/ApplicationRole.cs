﻿// ReSharper disable VirtualMemberCallInConstructor

using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AspNetCoreTemplate.Data.Models
{
    using System;

    using AspNetCoreTemplate.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public String Description { get; set; }
    }
}
