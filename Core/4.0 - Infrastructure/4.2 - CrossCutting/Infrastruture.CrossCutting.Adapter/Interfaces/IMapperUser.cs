using Application.DTO.DTO;
using Domain.Models;
using System.Collections.Generic;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperUser
    {
        #region Mappers

        User MapperToEntity(UserDTO userDTO);

        IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> obj);

        UserDTO MapperToDTO(User obj);

        #endregion

    }
}
