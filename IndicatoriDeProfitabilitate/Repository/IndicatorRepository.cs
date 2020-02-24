using IndicatoriDeProfitabilitate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Repository
{
    public class IndicatorRepository
    {
        private Models.DBObjects.CalculIndicatoriModelsDataContext dbContext;

        public IndicatorRepository()
        {
            this.dbContext = new Models.DBObjects.CalculIndicatoriModelsDataContext();
        }
        public IndicatorRepository(Models.DBObjects.CalculIndicatoriModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<IndicatorModel> GetAllIndicatori()
        {
            List<IndicatorModel> indicatorList = new List<IndicatorModel>();

            foreach (Models.DBObjects.Indicatori dbIndicator in dbContext.Indicatoris)
            {
                indicatorList.Add(MapDbObjectToModel(dbIndicator));
            }
            return indicatorList;
        }
        public IndicatorModel GetIndicatorById(Guid Id)
        {
            return MapDbObjectToModel(dbContext.Indicatoris.FirstOrDefault(x => x.IdIndicator == Id));

        }
        public void InsertIndicator(IndicatorModel indicatorModel)
        {
            indicatorModel.IdIndicator = Guid.NewGuid();
            dbContext.Indicatoris.InsertOnSubmit(MapModelToDbObject(indicatorModel));
            dbContext.SubmitChanges();
        }
        public void UpdateIndicator(IndicatorModel indicatorModel)
        {
            Models.DBObjects.Indicatori existingIndicator = dbContext.Indicatoris.FirstOrDefault(x => x.IdIndicator == indicatorModel.IdIndicator);

            if (existingIndicator != null)
            {
                existingIndicator.IdIndicator = indicatorModel.IdIndicator;
                existingIndicator.Denumire = indicatorModel.Denumire;
                existingIndicator.Descriere = indicatorModel.Descriere;
                existingIndicator.Formula_de_calcul = indicatorModel.Formula_de_calcul;

                dbContext.SubmitChanges();
            }

        }
        public void DeleteIndicator(Guid Id)
        {
            Models.DBObjects.Indicatori indicatorToDelete = dbContext.Indicatoris.FirstOrDefault(x => x.IdIndicator == Id);

            if (indicatorToDelete != null)
            {
                dbContext.Indicatoris.DeleteOnSubmit(indicatorToDelete);
                dbContext.SubmitChanges();
            }
        }
        private IndicatorModel MapDbObjectToModel(Models.DBObjects.Indicatori dbIndicator)
        {
            IndicatorModel indicatorModel = new IndicatorModel();

            if (dbIndicator != null)
            {
                indicatorModel.IdIndicator = dbIndicator.IdIndicator;
                indicatorModel.Denumire = dbIndicator.Denumire;
                indicatorModel.Descriere = dbIndicator.Descriere;
                indicatorModel.Formula_de_calcul = dbIndicator.Formula_de_calcul;
                return indicatorModel;
            }
            return null;
        }
        private Models.DBObjects.Indicatori MapModelToDbObject(IndicatorModel indicatorModel)
        {
            Models.DBObjects.Indicatori dbIndicatorModel = new Models.DBObjects.Indicatori();

            if (indicatorModel != null)
            {
                dbIndicatorModel.IdIndicator = indicatorModel.IdIndicator;
                dbIndicatorModel.Denumire = indicatorModel.Denumire;
                dbIndicatorModel.Descriere = indicatorModel.Descriere;
                dbIndicatorModel.Formula_de_calcul = indicatorModel.Formula_de_calcul;

                return dbIndicatorModel;
            }
            return null;
        }
    }
}