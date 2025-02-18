using Microsoft.AspNetCore.Mvc;

namespace SlackLab1Part3.Pages.ProjectClasses
{
    public class BUSINESSPARNTER{
        [BindProperty]
        public String BusinessPartnerID { get; set; }

        [BindProperty]
        public String Name { get; set; }

        [BindProperty]
        public String Status { get; set; }

        [BindProperty]
        public String Organization { get; set; }

        [BindProperty]
        public String OrganizationType { get; set; }

        [BindProperty]
        public String PrimaryContact { get; set; }

        [BindProperty]
        public String StatusFlag { get; set; }

        //primary contact choice of phone or email
        [BindProperty]
        public String contactType { get; set; }

        [BindProperty]
        public String contactInfo { get; set; }

        [BindProperty]
        public String statusFlag { get; set; }
    }
}
