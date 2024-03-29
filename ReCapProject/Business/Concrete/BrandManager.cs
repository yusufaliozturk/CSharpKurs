﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult <List<Brand>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());

        }
        public IDataResult<Brand> GetById(int brandID)
        {
            //select * from Brands where BrandID = 3
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandID == brandID));
        }
    }
}
