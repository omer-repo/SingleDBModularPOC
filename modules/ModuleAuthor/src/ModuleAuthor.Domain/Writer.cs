using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ModuleAuthor
{
    public class Writer: Entity<Guid>
    {
        public string Name { get; set; }
    }
}
