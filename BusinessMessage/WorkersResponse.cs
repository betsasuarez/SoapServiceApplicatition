using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapServiceApplicatition.BusinessMessage
{
    public class WorkersResponse
    {
        public List<Person> Workers{ get; set; }

        public bool ActionResult { get; set; }
        
        public string Error { get; set; }

    }
}