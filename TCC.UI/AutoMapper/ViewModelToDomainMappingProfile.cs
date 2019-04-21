using AutoMapper;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VMNewAccount, ETUser>();
        }
    }
}