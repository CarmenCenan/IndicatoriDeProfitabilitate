using IndicatoriDeProfitabilitate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Repository
{
    public class PublicatRepository
    {
        private Models.DBObjects.CalculIndicatoriModelsDataContext dbContext;

        public PublicatRepository()
        {
            this.dbContext = new Models.DBObjects.CalculIndicatoriModelsDataContext();
        }
        public PublicatRepository(Models.DBObjects.CalculIndicatoriModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<PublicatModel> GetAllPublicatii()
        {
            List<PublicatModel> publicatList = new List<PublicatModel>();

            foreach (Models.DBObjects.Publicatii dbPublicat in dbContext.Publicatiis)
            {
                publicatList.Add(MapDbObjectToModel(dbPublicat));
            }
            return publicatList;
        }
        public PublicatModel GetPublicatById(Guid Id)
        {
            return MapDbObjectToModel(dbContext.Publicatiis.FirstOrDefault(x => x.IdPublicat == Id));

        }
        public List<PublicatModel> GetPublicatiiByDateTimeAdded(DateTime dateTimeAdded)
        {
            List<PublicatModel> publicatList = new List<PublicatModel>();

            foreach (Models.DBObjects.Publicatii dbPublicat in dbContext.Publicatiis.Where(x => x.DateTimeAdded.Date  == dateTimeAdded.Date))
            {
                publicatList.Add(MapDbObjectToModel(dbPublicat));
            }
            return publicatList;
        }

        public void InsertPublicat(PublicatModel publicatModel)
        {
            publicatModel.IdPublicat = Guid.NewGuid();
            dbContext.Publicatiis.InsertOnSubmit(MapModelToDbObject(publicatModel));
            dbContext.SubmitChanges();
        }
        public void UpdatePublicat(PublicatModel publicatModel)
        {
            Models.DBObjects.Publicatii existingPublicat = dbContext.Publicatiis.FirstOrDefault(x => x.IdPublicat == publicatModel.IdPublicat);

            if (existingPublicat != null)
            {
                existingPublicat.IdPublicat = publicatModel.IdPublicat;
                existingPublicat.IdCompanie = publicatModel.IdCompanie;
                existingPublicat.IdUser = publicatModel.IdUser;
                existingPublicat.IdRotatie = publicatModel.IdRotatie;
                existingPublicat.DateTimeAdded = publicatModel.DateTimeAdded;

                dbContext.SubmitChanges();
            }

        }
        public void DeletePublicat(Guid Id)
        {
            Models.DBObjects.Publicatii publicatToDelete = dbContext.Publicatiis.FirstOrDefault(x => x.IdPublicat == Id);

            if (publicatToDelete != null)
            {
                dbContext.Publicatiis.DeleteOnSubmit(publicatToDelete);
                dbContext.SubmitChanges();
            }
        }
        private PublicatModel MapDbObjectToModel(Models.DBObjects.Publicatii dbPublicat)
        {
            PublicatModel publicatModel = new PublicatModel();

            if (dbPublicat != null)
            {
                publicatModel.IdPublicat = dbPublicat.IdPublicat;
                publicatModel.IdCompanie = dbPublicat.IdCompanie;
                publicatModel.IdUser = dbPublicat.IdUser;
                publicatModel.IdRotatie = dbPublicat.IdRotatie;
                publicatModel.DateTimeAdded = dbPublicat.DateTimeAdded;

                return publicatModel;
            }
            return null;
        }
        private Models.DBObjects.Publicatii MapModelToDbObject(PublicatModel publicatModel)
        {
            Models.DBObjects.Publicatii dbPublicatModel = new Models.DBObjects.Publicatii();

            if (publicatModel != null)
            {
                dbPublicatModel.IdPublicat = publicatModel.IdPublicat;
                dbPublicatModel.IdCompanie = publicatModel.IdCompanie;
                dbPublicatModel.IdUser = publicatModel.IdUser;
                dbPublicatModel.IdRotatie = publicatModel.IdRotatie;
                dbPublicatModel.DateTimeAdded = publicatModel.DateTimeAdded;

                return dbPublicatModel;
            }
            return null;
        }
    }
}