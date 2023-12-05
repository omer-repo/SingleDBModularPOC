using AutoMapper;

namespace ModuleAuthor;

public class ModuleAuthorApplicationAutoMapperProfile : Profile
{
    public ModuleAuthorApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Writer, WriterDto>();
        CreateMap<WriterDto, Writer>();

    }
}
