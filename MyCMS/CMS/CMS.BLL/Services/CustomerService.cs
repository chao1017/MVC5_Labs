﻿using AutoMapper;
using CMS.DAL.Interface;
using CMS.DAL.Repository;
using CMS.Domain;
using CMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMS.BLL.Services
{
    public class CustomerService
    {
        private IRepository<Customers> db;

        public CustomerService()
        {
            db = new GenericRepository<Customers>();
        }

        /// <summary>
        /// 取得所有客戶資料
        /// </summary>
        /// <returns></returns>
        public List<CustomerViewModel> Get()
        {
            #region 很累的寫法(一個一個丟)
            //List<CustomerViewModel> model = new List<CustomerViewModel>();
            //var DbResult = db.Get().AsQueryable();
            //
            //foreach (var item in DbResult)
            //{
            //    //將Customers的清單資料一個一個丟到CustomerViewModel
            //    CustomerViewModel _model = new CustomerViewModel();
            //    _model.CustomerID = item.CustomerID;
            //    _model.ContactName = item.ContactName;
            //    model.Add(_model);
            //}
            //
            //return model.AsQueryable();
            #endregion

            #region 改用AutoMapper
            var DbResult = db.Get().ToList();
            //AntoMapper before V4.2
            //Mapper.CreateMap<Customers, CustomerViewModel>();
            //
            //return Mapper.Map<List<Customers>, List<CustomerViewModel>>(DbResult);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customers, CustomerViewModel>());
            config.AssertConfigurationIsValid();//驗證應對

            var mapper = config.CreateMapper();
            return mapper.Map<List<Customers>, List<CustomerViewModel>>(DbResult);
            #endregion
        }

        public IQueryable<CustomerViewModel> Get(int CurrPage, int PageSize, out int TotalRow)
        {
            // 取得所有筆數
            TotalRow = db.Get().ToList().Count();

            // 使用Linq篩選分頁
            var DbResult = db.Get().ToList().Skip((CurrPage - 1) * PageSize).Take(PageSize).ToList();

            // Mapping到ViewModel
            
            //AutoMapper V4.2 以前的寫法
            //Mapper.CreateMap<Customers, CustomerViewModel>();
            //return Mapper.Map<List<Customers>, List<CustomerViewModel>>(DbResult).AsQueryable();

            //AutoMapper V >= 4.2 的寫法
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customers, CustomerViewModel>());
            config.AssertConfigurationIsValid();//驗證應對

            var mapper = config.CreateMapper();
            return mapper.Map<List<Customers>, List<CustomerViewModel>>(DbResult).AsQueryable();
        }
    }
}
