using Application.DTO.DTO;
using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Application.Service
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        private readonly IMapperUser _mapperUser;

        public ApplicationServiceUser(IServiceUser ServiceUser, IMapperUser MapperUser)
        {
            _serviceUser = ServiceUser;
            _mapperUser = MapperUser;
        }

        public void Add(UserDTO obj)
        {
            var objUser = _mapperUser.MapperToEntity(obj);
            _serviceUser.Add(objUser);
        }

        public void Dispose()
        {
            _serviceUser.Dispose();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var objProdutos = _serviceUser.GetAll();
            return _mapperUser.MapperListUsers(objProdutos);
        }

        public UserDTO GetById(int id)
        {
            var objUser = _serviceUser.GetById(id);
            return _mapperUser.MapperToDTO(objUser);
        }

        public void Remove(UserDTO obj)
        {
            var objUser = _mapperUser.MapperToEntity(obj);
            _serviceUser.Remove(objUser);
        }

        public void Update(UserDTO obj)
        {
            var objUser = _mapperUser.MapperToEntity(obj);
            _serviceUser.Update(objUser);
        }
    }
}
