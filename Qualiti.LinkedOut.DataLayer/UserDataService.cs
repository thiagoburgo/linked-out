using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qualiti.LinkedOut.BusinessDataLayerContracts;
using Qualiti.LinkedOut.Entities;

namespace Qualiti.LinkedOut.DataLayer {
    public class UserDataService : IUserDataService
    {
        public List<User> List()
        {
            //Buscar do BD criar uma lista de users e retornar
            return null;
        }

        public void Delete(object key)
        {
            //Deletar do BD o usuario com a chave indicada
        }

        public void Delete(User entity)
        {
            //Deletar do BD o usuario
        }

        public void Update(object keyForUpdate, User newEntity)
        {
            //Atualizar no BD o usuario
        }

        public object Create(User newEntity)
        {
            //Criar no BD o usuario
            return null;
        }
    }
}