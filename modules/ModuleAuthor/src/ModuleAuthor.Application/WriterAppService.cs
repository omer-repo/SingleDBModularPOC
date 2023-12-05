using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ModuleAuthor
{
    public class WriterAppService: ModuleAuthorAppService
    {
        private readonly IRepository<Writer, Guid> _repository;

        public WriterAppService(IRepository<Writer, Guid> repository)
        {
            this._repository = repository;
        }

        public async Task<List<WriterDto>> GetAll()
        {
            var writers = await _repository.GetListAsync();
            return ObjectMapper.Map<List<Writer>, List<WriterDto>>(writers);
        }

        public async Task<WriterDto> Get(Guid id)
        {
            var writer = await _repository.GetAsync(id);
            return ObjectMapper.Map<Writer, WriterDto>(writer);
        }

        public async Task<WriterDto> Create(WriterDto input)
        {
            var writer = ObjectMapper.Map<WriterDto, Writer>(input);
            writer = await _repository.InsertAsync(writer);
            return ObjectMapper.Map<Writer, WriterDto>(writer);
        }

        public async Task<WriterDto> Update(Guid id, WriterDto input)
        {
            var Writer = ObjectMapper.Map<WriterDto, Writer>(input);
            var updatedWriter = await _repository.UpdateAsync(Writer);
            return ObjectMapper.Map<Writer, WriterDto>(updatedWriter);
        }

        public async Task Delete(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
