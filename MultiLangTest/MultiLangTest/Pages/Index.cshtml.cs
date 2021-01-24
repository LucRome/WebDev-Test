using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MultiLangTest.Pages
{
    public class IndexModel : PageModel
    {
        public MultiLangStringCollection mls;
        public string Lang;
        
        public void OnGet(string language)
        {
            /*Initalise mls*/
            mls = Examples.multiLangStringCollection();
            Lang = language;
        }
    }
}
