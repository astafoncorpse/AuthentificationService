using AuthentificationService.DAL.Entities;
using AuthentificationService.PLL.Views;
using AutoMapper;

namespace AuthentificationService.BLL.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
            .ConstructUsing(v => new UserViewModel(v));
        }

    }
}
