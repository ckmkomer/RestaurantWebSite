﻿using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
          _featureDal.Add(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
          return  _featureDal.GetByID(id);
        }

        public List<Feature> TGetList()
        {
          return  _featureDal.GetList();
        }

        public List<Feature> TGetListbyFilter(int id)
        {
            return _featureDal.GetByFilter(x=> x.Id == id);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
