using Microsoft.AspNetCore.Mvc;

namespace SlackLab1Part3.Pages.ProjectClasses
{
    public class GRANT
    {
        public int GrantID { get; set; }

        public string Category { get; set; }

        public string FundingOrg { get; set; }

        public DateTime? SubmissionDate { get; set; }

        public DateTime? AwardDate { get; set; }

        public decimal AwardSubtotal { get; set; }

        public String GrantStatus { get; set; }

        //Document for Lab1 mentioned ability to add lead faculty/other faculty
        [BindProperty]
        public string LeadFaculty { get; set; }

        [BindProperty]
        public string AdditionalFaculty { get; set; }

        [BindProperty]
        public string Status { get; set; }
    }
}
