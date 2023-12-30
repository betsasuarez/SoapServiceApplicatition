using SoapServiceApplicatition.BusinessMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapServiceApplicatition.BusinessAction
{
    public static class WorkersManager

    {
        public static WorkersResponse GetAllWorkers()
        {
           var workers = new  List<Person>() {
               new Person()
               
               {
                 FullName= "Roberto Carlo"
               }               
           };
            {
                new Person()
                {
                   FullName= "maria lopez"
                };
            }

            return new WorkersResponse()
            {
                Workers = workers
            };
            
        }

    }
}