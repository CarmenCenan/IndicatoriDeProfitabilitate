using IndicatoriDeProfitabilitate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Repository
{
    public class UserRepository
    {
        private Models.DBObjects.CalculIndicatoriModelsDataContext dbContext;

        public UserRepository()
        {
            this.dbContext = new Models.DBObjects.CalculIndicatoriModelsDataContext();
        }
        public UserRepository(Models.DBObjects.CalculIndicatoriModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<UserModel> GetAllUsers()
        {
            List<UserModel> userList = new List<UserModel>();

            foreach (Models.DBObjects.User dbUser in dbContext.Users)
            {
                userList.Add(MapDbObjectToModel(dbUser));
            }
            return userList;
        }
        public UserModel GetUserById(Guid Id)
        {
            return MapDbObjectToModel(dbContext.Users.FirstOrDefault(x => x.IdUser == Id));

        }
        public void InsertUser(UserModel userModel)
        {
            userModel.IdUser = Guid.NewGuid();
            dbContext.Users.InsertOnSubmit(MapModelToDbObject(userModel));
            dbContext.SubmitChanges();
        }
        public void UpdateUser(UserModel userModel)
        {
            Models.DBObjects.User existingUser = dbContext.Users.FirstOrDefault(x => x.IdUser == userModel.IdUser);

            if (existingUser != null)
            {
                existingUser.IdUser = userModel.IdUser;
                existingUser.IdCompanie = userModel.IdCompanie;
                existingUser.Nume = userModel.Nume;
                existingUser.Prenume = userModel.Prenume;
                existingUser.Functie = userModel.Functie;

                dbContext.SubmitChanges();
            }
        }
        public void DeleteUser(Guid Id)
        {
            Models.DBObjects.User userToDelete = dbContext.Users.FirstOrDefault(x => x.IdUser == Id);

            if (userToDelete != null)
            {
                dbContext.Users.DeleteOnSubmit(userToDelete);
                dbContext.SubmitChanges();
            }
        }
        private UserModel MapDbObjectToModel(Models.DBObjects.User dbUser)
        {
            UserModel userModel = new UserModel();

            if (dbUser != null)
            {
                userModel.IdUser = dbUser.IdUser;
                userModel.IdCompanie = dbUser.IdCompanie;
                userModel.Nume = dbUser.Nume;
                userModel.Prenume = dbUser.Prenume;
                userModel.Functie = dbUser.Functie;
               
                return userModel;
            }
            return null;
        }
        private Models.DBObjects.User MapModelToDbObject(UserModel userModel)
        {
            Models.DBObjects.User dbUserModel = new Models.DBObjects.User();

            if (userModel != null)
            {
                dbUserModel.IdUser = userModel.IdUser;
                dbUserModel.IdCompanie = userModel.IdCompanie;
                dbUserModel.Nume = userModel.Nume;
                dbUserModel.Prenume = userModel.Prenume;
                dbUserModel.Functie = userModel.Functie;
               

                return dbUserModel;
            }
            return null;
        }
    }
}