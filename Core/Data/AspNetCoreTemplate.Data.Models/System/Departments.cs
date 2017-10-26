﻿using AspNetCoreTemplate.Data.Common.Models;

namespace Krista.FM.Domain
{
    public class Departments : DomainObject
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}