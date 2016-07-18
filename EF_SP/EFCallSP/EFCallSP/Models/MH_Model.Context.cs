﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFCallSP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CTCI_MH_DBEntities : DbContext
    {
        public CTCI_MH_DBEntities()
            : base("name=CTCI_MH_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<corp_SP_list> corp_SP_list { get; set; }
        public virtual DbSet<gmh_leave_hr_list> gmh_leave_hr_list { get; set; }
        public virtual DbSet<gmh_z_code_list> gmh_z_code_list { get; set; }
        public virtual DbSet<gmh_zz_code_type> gmh_zz_code_type { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<calendar> calendar { get; set; }
        public virtual DbSet<calendar_list> calendar_list { get; set; }
        public virtual DbSet<corp_leave_permit> corp_leave_permit { get; set; }
        public virtual DbSet<gmh_apply_leave> gmh_apply_leave { get; set; }
        public virtual DbSet<gmh_approver_special> gmh_approver_special { get; set; }
        public virtual DbSet<gmh_auto_gen_mh_special> gmh_auto_gen_mh_special { get; set; }
        public virtual DbSet<gmh_checker> gmh_checker { get; set; }
        public virtual DbSet<gmh_checker_log> gmh_checker_log { get; set; }
        public virtual DbSet<gmh_chk_unit_prj> gmh_chk_unit_prj { get; set; }
        public virtual DbSet<gmh_corp_tab> gmh_corp_tab { get; set; }
        public virtual DbSet<gmh_data> gmh_data { get; set; }
        public virtual DbSet<gmh_data_pre> gmh_data_pre { get; set; }
        public virtual DbSet<gmh_data_reject> gmh_data_reject { get; set; }
        public virtual DbSet<gmh_data_tmp_leave> gmh_data_tmp_leave { get; set; }
        public virtual DbSet<gmh_data1> gmh_data1 { get; set; }
        public virtual DbSet<gmh_deputy_detail> gmh_deputy_detail { get; set; }
        public virtual DbSet<gmh_deputy_item_list> gmh_deputy_item_list { get; set; }
        public virtual DbSet<gmh_deputy_master> gmh_deputy_master { get; set; }
        public virtual DbSet<gmh_for_mp> gmh_for_mp { get; set; }
        public virtual DbSet<gmh_for_salary> gmh_for_salary { get; set; }
        public virtual DbSet<gmh_for_salary_oversea> gmh_for_salary_oversea { get; set; }
        public virtual DbSet<gmh_for_salary1> gmh_for_salary1 { get; set; }
        public virtual DbSet<gmh_holiday> gmh_holiday { get; set; }
        public virtual DbSet<gmh_keyin_flab> gmh_keyin_flab { get; set; }
        public virtual DbSet<gmh_leave_form> gmh_leave_form { get; set; }
        public virtual DbSet<gmh_leave_form_detail> gmh_leave_form_detail { get; set; }
        public virtual DbSet<gmh_leave_storage> gmh_leave_storage { get; set; }
        public virtual DbSet<gmh_leave_storage_053> gmh_leave_storage_053 { get; set; }
        public virtual DbSet<gmh_leave_storage_resign_013> gmh_leave_storage_resign_013 { get; set; }
        public virtual DbSet<gmh_leave_storage_year_summary_013> gmh_leave_storage_year_summary_013 { get; set; }
        public virtual DbSet<gmh_leave_used_record_013_9933002> gmh_leave_used_record_013_9933002 { get; set; }
        public virtual DbSet<gmh_leave_used_record_053> gmh_leave_used_record_053 { get; set; }
        public virtual DbSet<gmh_message_for_003_left> gmh_message_for_003_left { get; set; }
        public virtual DbSet<gmh_ot_over_46_permit> gmh_ot_over_46_permit { get; set; }
        public virtual DbSet<gmh_overtime_form> gmh_overtime_form { get; set; }
        public virtual DbSet<gmh_overtime_form_detail> gmh_overtime_form_detail { get; set; }
        public virtual DbSet<gmh_pm_in_site> gmh_pm_in_site { get; set; }
        public virtual DbSet<gmh_resign_lock> gmh_resign_lock { get; set; }
        public virtual DbSet<gmh_RN_prj_checker> gmh_RN_prj_checker { get; set; }
        public virtual DbSet<HR_emp_OT_flag> HR_emp_OT_flag { get; set; }
        public virtual DbSet<message> message { get; set; }
        public virtual DbSet<month_frozen> month_frozen { get; set; }
        public virtual DbSet<oversea_leave_confirm> oversea_leave_confirm { get; set; }
        public virtual DbSet<oversea_leave_to_bonus_record> oversea_leave_to_bonus_record { get; set; }
        public virtual DbSet<overtime_permit_special> overtime_permit_special { get; set; }
        public virtual DbSet<prj_type_list> prj_type_list { get; set; }
    
        public virtual ObjectResult<s_gmh_get_leave_form_data_Result> s_gmh_get_leave_form_data(string form_id, string corp_id)
        {
            var form_idParameter = form_id != null ?
                new ObjectParameter("form_id", form_id) :
                new ObjectParameter("form_id", typeof(string));
    
            var corp_idParameter = corp_id != null ?
                new ObjectParameter("corp_id", corp_id) :
                new ObjectParameter("corp_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<s_gmh_get_leave_form_data_Result>("s_gmh_get_leave_form_data", form_idParameter, corp_idParameter);
        }
    }
}
