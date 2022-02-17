using Application.DTO.DTO;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDTO obj);

        UserDTO GetById(int id);

        IEnumerable<UserDTO> GetAll();

        void Update(UserDTO obj);

        void Remove(UserDTO obj);

        void Dispose();
    }
}
