using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ModuleAuthor
{
    public class WriterDto: EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
