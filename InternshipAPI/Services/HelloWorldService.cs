using InternshipAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Services
{
    public class HelloWorldService
    {


        public static string Hello(string name)
        {
            string responseHelloWorld = string.Empty;
            try
            {
                HelloWorldRepository wordRepo = new HelloWorldRepository();

                responseHelloWorld = wordRepo.Say_Hello(name);
            }
            catch (Exception ex)
            {

                //mesajele de eroare se logheaz in baza de date intr-o tabela de log-uri
                var mesajEroare = ex.Message;
            }
            return responseHelloWorld;
        }
    }
}