using Microsoft.AspNetCore.Mvc;

namespace SlackLab1Part3.Pages.ProjectClasses
{
    public class GRANT
    {
        [BindProperty]
        public string GrantID { get; set; }

        [BindProperty]
        public string Category { get; set; }

        [BindProperty]
        public string FundingOrg { get; set; }

        [BindProperty]
        public DateOnly SubmissionDate { get; set; }

        [BindProperty]
        public DateOnly AwardDate { get; set; }

        [BindProperty]
        public double AwardSubtotal { get; set; }

        [BindProperty]
        public String GrantStatus { get; set; }

        //Document for Lab1 mentioned ability to add lead faculty/other faculty
        [BindProperty]
        public string leadFaculty { get; set; }

        [BindProperty]
        public string additionalFaculty { get; set; }

        [BindProperty]
        public string status { get; set; }
    }
}
