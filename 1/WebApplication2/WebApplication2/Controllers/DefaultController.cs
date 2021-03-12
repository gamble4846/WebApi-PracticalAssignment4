using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/Uppercase")]
        [HttpGet]
        public String Uppercase(String str)
        {
            return str.ToUpper();
        }

        [Route("api/Lowercase")]
        [HttpGet]
        public String Lowercase(String str)
        {
            return str.ToLower();
        }


        [Route("api/Reversecase")]
        [HttpGet]
        public String Reversecase(String str)
        {
            String ReversedString = new string(str.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
            return ReversedString;
        }

        [Route("api/Capitalize")]
        [HttpGet]
        public String capitalize(String str)
        {
            bool flag = false;
            String CapitalizedString = "";

            for(int i=0;i<str.Length;i++)
            {
                if (str[i].Equals(' ') || i == 0)
                {
                    flag = true;
                    if(str[i].Equals(' '))
                    {
                        CapitalizedString += ' ';
                        i++;
                    }
                }
                else
                {
                    flag = false;
                }
                CapitalizedString += (flag) ? str[i].ToString().ToUpper() : str[i].ToString();
            }

            return CapitalizedString;
        }
    }
}
