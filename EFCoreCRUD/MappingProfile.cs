using AutoMapper;
using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;

namespace EFCoreCRUD
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<DTOPost, Post>();
            CreateMap<DTOComment, Comment>();
            
        }
    }
}
