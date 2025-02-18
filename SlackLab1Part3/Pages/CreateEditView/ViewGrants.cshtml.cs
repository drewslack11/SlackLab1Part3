using Microsoft.AspNetCore.Mvc.RazorPages;
using SlackLab1Part3.Pages.DB;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using SlackLab1Part3.Pages.ProjectClasses;

namespace SlackLab1Part3.Pages.CreateEditView
{
    public class ViewGrantsModel : PageModel
    {
        public List<GRANT> GrantList { get; set; } 
        
        public ViewGrantsModel() 
        { 
            GrantList = new List<GRANT>();
        }
        public void OnGet()
        {
            SqlDataReader cmdGrantRead = DBClass.GrantReader();
            while (cmdGrantRead.Read())
            {
                GrantList.Add(new GRANT
                {
                    GrantID = Int32.Parse(cmdGrantRead["GrantID"].ToString()),
                    Category = cmdGrantRead["Category"].ToString(),
                    FundingOrg = cmdGrantRead["FundingOrg"].ToString(),
                    SubmissionDate = cmdGrantRead["SubmissionDate"].ToString() != "" ? DateTime.Parse(cmdGrantRead["SubmissionDate"].ToString()) : (DateTime?)null,
                    AwardDate = cmdGrantRead["AwardDate"].ToString() != "" ? DateTime.Parse(cmdGrantRead["AwardDate"].ToString()) : (DateTime?)null,
                    AwardSubtotal = cmdGrantRead["AwardSubtotal"] != DBNull.Value ? (decimal)cmdGrantRead["AwardSubtotal"] : 0,
                    GrantStatus = cmdGrantRead["GrantStatus"].ToString()
                }) ;
                
            }
            DBClass.Lab1DBConnection.Close();  
        }
    }
}

