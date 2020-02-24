using IndicatoriDeProfitabilitate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Repository
{
    public class RotatieRepository
    {
        private Models.DBObjects.CalculIndicatoriModelsDataContext dbContext;

        public RotatieRepository()
        {
            this.dbContext = new Models.DBObjects.CalculIndicatoriModelsDataContext();
        }
        public RotatieRepository(Models.DBObjects.CalculIndicatoriModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<RotatieModel> GetAllRotatii()
        {
            List<RotatieModel> rotatieList = new List<RotatieModel>();

            foreach (Models.DBObjects.Rotatii dbRotatie in dbContext.Rotatiis)
            {
                rotatieList.Add(MapDbObjectToModel(dbRotatie));
            }
            return rotatieList;
        }
        public RotatieModel GetRotatieById(Guid Id)
        {
            return MapDbObjectToModel(dbContext.Rotatiis.FirstOrDefault(x => x.IdRotatie == Id));

        }
        public void InsertRotatie(RotatieModel rotatieModel)
        {
            rotatieModel.IdRotatie = Guid.NewGuid();
            dbContext.Rotatiis.InsertOnSubmit(MapModelToDbObject(rotatieModel));
            dbContext.SubmitChanges();
        }
        public void UpdateRotatie(RotatieModel rotatieModel)
        {
            Models.DBObjects.Rotatii existingRotatie = dbContext.Rotatiis.FirstOrDefault(x => x.IdRotatie == rotatieModel.IdRotatie);

            if (existingRotatie != null)
            {
                existingRotatie.IdRotatie = rotatieModel.IdRotatie;
                existingRotatie.IdCompanie = rotatieModel.IdCompanie;
                existingRotatie.IdUser = rotatieModel.IdUser;
                existingRotatie.Cost_marfa_vanduta = rotatieModel.Cost_marfa_vanduta;
                existingRotatie.Valoare_stoc_mediu = rotatieModel.Cost_marfa_vanduta;
                existingRotatie.Valoare_indicator = rotatieModel.Valoare_indicator;
                existingRotatie.Public = rotatieModel.Public;

                dbContext.SubmitChanges();
            }
        }
        public void DeleteRotatie(Guid Id)
        {
            Models.DBObjects.Rotatii rotatieToDelete = dbContext.Rotatiis.FirstOrDefault(x => x.IdRotatie == Id);

            if (rotatieToDelete != null)
            {
                dbContext.Rotatiis.DeleteOnSubmit(rotatieToDelete);
                dbContext.SubmitChanges();
            }
        }
        private RotatieModel MapDbObjectToModel(Models.DBObjects.Rotatii dbRotatie)
        {
            RotatieModel rotatieModel = new RotatieModel();

            if (dbRotatie != null)
            {
                rotatieModel.IdRotatie = dbRotatie.IdRotatie;
                rotatieModel.IdCompanie = dbRotatie.IdCompanie;
                rotatieModel.IdUser = dbRotatie.IdUser;
                rotatieModel.Cost_marfa_vanduta = dbRotatie.Cost_marfa_vanduta;
                rotatieModel.Valoare_stoc_mediu = dbRotatie.Valoare_stoc_mediu;
                rotatieModel.Valoare_indicator = dbRotatie.Valoare_indicator;
                rotatieModel.Public = dbRotatie.Public;


                return rotatieModel;
            }
            return null;
        }
        private Models.DBObjects.Rotatii MapModelToDbObject(RotatieModel rotatieModel)
        {
            Models.DBObjects.Rotatii dbRotatieModel = new Models.DBObjects.Rotatii();

            if (rotatieModel != null)
            {
                dbRotatieModel.IdRotatie = rotatieModel.IdRotatie;
                dbRotatieModel.IdCompanie = rotatieModel.IdCompanie;
                dbRotatieModel.IdUser = rotatieModel.IdUser;
                dbRotatieModel.Cost_marfa_vanduta = rotatieModel.Cost_marfa_vanduta;
                dbRotatieModel.Valoare_stoc_mediu = rotatieModel.Valoare_stoc_mediu;
                dbRotatieModel.Valoare_indicator = rotatieModel.Valoare_indicator;
                dbRotatieModel.Public = rotatieModel.Public;

                return dbRotatieModel;
            }
            return null;
        }
    }
}