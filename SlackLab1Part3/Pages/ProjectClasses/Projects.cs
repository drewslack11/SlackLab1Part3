using Microsoft.AspNetCore.Mvc;

namespace SlackLab1Part3.Pages.ProjectClasses
{
    public class PROJECT{
        [BindProperty]
        public String ProjectID { get; set; }

        [BindProperty]
        public String Title { get; set; }

        [BindProperty]
        public String Description { get; set; }

        [BindProperty]
        public DateOnly DueDate { get; set; }

        [BindProperty]
        public String Status { get; set; }
    }
}
