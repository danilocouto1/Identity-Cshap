using AutoMapper;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
