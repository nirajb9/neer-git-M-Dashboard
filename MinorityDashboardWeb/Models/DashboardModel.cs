﻿using MinorityDashboard.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinorityDashboardWeb.Models
{
    public class DashboardModel
    {
        public int tran_id { get; set; }
        public int desk_id { get; set; }
        public int scheme_id { get; set; }
        public int des_id { get; set; }
        public int fin_y_id { get; set; }
        public int sub_id { get; set; }
        public int est_id { get; set; }
        public decimal budgetary_provision_amt { get; set; }
        public decimal actual_allocation_amt { get; set; }

        public decimal actual_expenditure_amt { get; set; }
        public decimal actual_remaining_amt { get; set; }

        public int desk_officer_id { get; set; }

        public List<GetDeskTransactionData_Result> lstDeskTransData { set; get; }
        public List<GetDeskDocuments_Result> lstDeskDocData { set; get; }

        public List<trans_docfile> lstDeskDocFile { set; get; }
        public List<SelectListItem> lstSubject { get; set; }
        public List<SelectListItem> lstDesk { get; set; }
        public List<SelectListItem> lstScheme { get; set; }
        public List<SelectListItem> lstFinancialYear { get; set; }
        public List<SelectListItem> lstDistrict { get; set; }
        public List<SelectListItem> lstEstimatipn { get; set; }

        public FinancialYearCount FinancialYearwiseCounr { get; set; }
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] UploadDoc { get; set; }

        public string DocTitle { get; set; }
    }

    public class SubjectModel
    {
        public int sub_id { get; set; }
        public int desk_id { get; set; }
        public string sub_name { get; set; }
        public List<SelectListItem> lstDesk { get; set; }
        public List<GetSubjectData_Result> lstSubject { get; set; }
    }
    public class DeskModel
    {
        public List<desk_master> lstDeskMaster { get; set; }
        public int desk_id { get; set; }
        public string desk_name { get; set; }
    }

    public class Desk
    {
       
    }

    public class SchemeModel
    {
        public int scheme_id { get; set; }
        public string scheme_name { get; set; }
        public string scheme_description { get; set; }
        public int sub_id { get; set; }
        public int desk_id { get; set; }
        public List<SelectListItem> lstSubject { get; set; }
        public List<SelectListItem> lstDesk { get; set; }
        public List<GetSchemeData_Result> lstSchems { get; set; }
    }

    public class FinancialYearModel
    {
        public int fin_y_id { get; set; }
        public string fin_y_name { get; set; }
    }

    public class DistrictModel
    {
        public int des_id { get; set; }
        public string des_name { get; set; }
    }

   public class FinancialYearCount
    {
        public decimal D1FY2017_18 { get; set; }
        public decimal D1FY2018_19 { get; set; }

        public decimal D2FY2017_18 { get; set; }
        public decimal D2FY2018_19 { get; set; }

        public decimal D3FY2017_18 { get; set; }
        public decimal D3FY2018_19 { get; set; }

        public decimal D4FY2017_18 { get; set; }
        public decimal D4FY2018_19 { get; set; }
    
        public decimal D5FY2017_18 { get; set; }
        public decimal D5FY2018_19 { get; set; }

        public decimal D6FY2017_18 { get; set; }
        public decimal D6FY2018_19 { get; set; }

        public decimal D7FY2017_18 { get; set; }
        public decimal D7FY2018_19 { get; set; }

        public decimal D8FY2017_18 { get; set; }
        public decimal D8FY2018_19 { get; set; }

        public decimal D9FY2017_18 { get; set; }
        public decimal D9FY2018_19 { get; set; }

    }

}