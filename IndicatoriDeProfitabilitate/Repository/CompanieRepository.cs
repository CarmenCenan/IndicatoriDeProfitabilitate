using IndicatoriDeProfitabilitate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Repository
{
    public class CompanieRepository
    {
        private Models.DBObjects.CalculIndicatoriModelsDataContext dbContext;

        public CompanieRepository()
        {
            this.dbContext = new Models.DBObjects.CalculIndicatoriModelsDataContext();
        }
        public CompanieRepository(Models.DBObjects.CalculIndicatoriModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<CompanieModel> GetAllCompanii()
        {
            List<CompanieModel> companieList = new List<CompanieModel>();

            foreach (Models.DBObjects.Companii dbCompanie in dbContext.Companiis)
 {
                companieList.Add(MapDbObjectToModel(dbCompanie));
            }
            return companieList;
        }
        public CompanieModel GetCompanieById(Guid Id)
        {
            return MapDbObjectToModel(dbContext.Companiis.FirstOrDefault(x => x.IdCompanie == Id));

        }
        public void InsertCompanie(CompanieModel companieModel)
        {
            companieModel.IdCompanie = Guid.NewGuid();
            dbContext.Companiis.InsertOnSubmit(MapModelToDbObject(companieModel));
            dbContext.SubmitChanges();
        }
        public void UpdateCompanie(CompanieModel companieModel)
        {
            Models.DBObjects.Companii existingCompanie = dbContext.Companiis.FirstOrDefault(x => x.IdCompanie == companieModel.IdCompanie);

            if ( existingCompanie != null)
            {
                existingCompanie.IdCompanie = companieModel.IdCompanie;
                existingCompanie.Nume_Companie = companieModel.Nume_Companie;

                dbContext.SubmitChanges();
            }

        }
        public void DeleteCompanie (Guid Id)
        {
            Models.DBObjects.Companii companieToDelete = dbContext.Companiis.FirstOrDefault(x => x.IdCompanie == Id);

            if(companieToDelete != null)
            {
                dbContext.Companiis.DeleteOnSubmit(companieToDelete);
                dbContext.SubmitChanges();
            }
        }
        private CompanieModel MapDbObjectToModel(Models.DBObjects.Companii dbCompanie)
        {
            CompanieModel companieModel = new CompanieModel();

            if(dbCompanie != null)
            {
                companieModel.IdCompanie = dbCompanie.IdCompanie;
                companieModel.Nume_Companie = dbCompanie.Nume_Companie;

                return companieModel;
            }
            return null;
        }
        private Models.DBObjects.Companii MapModelToDbObject (CompanieModel companieModel)
        {
            Models.DBObjects.Companii dbCompanieModel = new Models.DBObjects.Companii();

            if(companieModel != null)
            {
                dbCompanieModel.IdCompanie = companieModel.IdCompanie;
                dbCompanieModel.Nume_Companie = companieModel.Nume_Companie;

                return dbCompanieModel;
            }
            return null;
        }
    }
}