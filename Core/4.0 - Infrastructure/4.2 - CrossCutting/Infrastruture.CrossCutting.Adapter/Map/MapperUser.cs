using Application.DTO.DTO;
using Domain.Models;
using Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperUser : IMapperUser
    {

        #region properties
        List<UserDTO> userDTOs = new List<UserDTO>();
        #endregion

        #region methods

        public User MapperToEntity(UserDTO dto)
        {
            User obj = new User
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                Gender = dto.Gender
            };
            return obj;
        }

        public IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> obj)
        {
            foreach (var item in obj)
            {
                UserDTO dto = new UserDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Gender = item.Gender
                };

                userDTOs.Add(dto);
            }
            return userDTOs;
        }

        public UserDTO MapperToDTO(User obj)
        {
            UserDTO dto = new UserDTO
            {
                Name = obj.Name,
                Email = obj.Email,
                Gender = obj.Gender
            };
            return dto;

        }
        #endregion

    }
}
