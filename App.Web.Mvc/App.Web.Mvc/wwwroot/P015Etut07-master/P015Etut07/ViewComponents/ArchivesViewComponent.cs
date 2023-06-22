using Microsoft.AspNetCore.Mvc;

namespace P015Etut07.ViewComponents
{
    public class ArchivesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Veri tabanına git
            //Veri tabanında dataları al
            //Uygun hale getir

            var archives = new List<string>()
            {
                "aaaaaaaaaaaaaaaaaa",
                "March 2021   ",
                "February 2021 ",
                "January 2021  ",
                "December 2020 ",
                "November 2020 ",
                "October 2020  ",
                "September 2020",
                "August 2020  " ,
                "July 2020 "    ,
                "June 2020 "    ,
                "May 2020  "    ,
                "April 2020"    ,
            };

            return View(archives);
        }
    }
}
