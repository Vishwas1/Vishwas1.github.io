using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempleRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string accessToken = String.Empty; 
        Service1() { 
        
        } 
        List<Devoters> IService1.GetListOfDevoters(string rqstAccessToken)
        {
           
             List<Devoters> devList=null;
             try {
                 if (!String.IsNullOrEmpty(rqstAccessToken)) {
                     if (rqstAccessToken.Equals(accessToken))
                     {
                         devList = new List<Devoters>();
                         #region devList
                         Devoters dev = new Devoters();
                         dev.Id = "101";
                         dev.Age = "25";
                         dev.Doj = "12/11/2012";
                         dev.Address = "Kolkata";
                         dev.Phoneno = "1234";
                         dev.Name = "vishwas";
                         devList.Add(dev);

                         Devoters dev1 = new Devoters();
                         dev1.Name = "Vishwas";
                         dev1.Id = "101";
                         dev1.Age = "25";
                         dev1.Doj = "12/11/2012";
                         dev1.Address = "Kolkata";
                         dev1.Phoneno = "1234";
                         devList.Add(dev1);

                         Devoters dev2 = new Devoters();
                         dev2.Name = "Dharmendra";
                         dev2.Id = "101";
                         dev2.Age = "25";
                         dev2.Doj = "12/11/2012";
                         dev2.Address = "Kolkata";
                         dev2.Phoneno = "1234";
                         devList.Add(dev2);

                         Devoters dev3 = new Devoters();
                         dev3.Name = "Vikram";
                         dev3.Id = "101";
                         dev3.Age = "25";
                         dev3.Doj = "12/11/2012";
                         dev3.Address = "Kolkata";
                         dev3.Phoneno = "1234";
                         devList.Add(dev3);

                         Devoters dev8 = new Devoters();
                         dev8.Name = "Vikram";
                         dev8.Id = "101";
                         dev8.Age = "25";
                         dev8.Doj = "12/11/2012";
                         dev8.Address = "Kolkata";
                         dev8.Phoneno = "1234";
                         devList.Add(dev8);

                         Devoters dev4 = new Devoters();
                         dev4.Name = "Vikram";
                         dev4.Id = "101";
                         dev4.Age = "25";
                         dev4.Doj = "12/11/2012";
                         dev4.Address = "Kolkata";
                         dev4.Phoneno = "1234";
                         devList.Add(dev4);

                         Devoters dev5 = new Devoters();
                         dev5.Name = "Vikram";
                         dev5.Id = "101";
                         dev5.Age = "25";
                         dev5.Doj = "12/11/2012";
                         dev5.Address = "Kolkata";
                         dev5.Phoneno = "1234";
                         devList.Add(dev5);

                         Devoters dev6 = new Devoters();
                         dev6.Name = "Vikram";
                         dev6.Id = "101";
                         dev6.Age = "25";
                         dev6.Doj = "12/11/2012";
                         dev6.Address = "Kolkata";
                         dev6.Phoneno = "1234";
                         devList.Add(dev6);

                         Devoters dev7 = new Devoters();
                         dev7.Name = "Vikram";
                         dev7.Id = "101";
                         dev7.Age = "25";
                         dev7.Doj = "12/11/2012";
                         dev7.Address = "Kolkata";
                         dev7.Phoneno = "1234";
                         devList.Add(dev7);
                        
                         #endregion

                     }
                     else {
                         devList = null;
                     }
                 }
             }catch(Exception  ex) {
             
             }

            return devList;
        }


        private string Decryptdata(string data)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(data);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }


        public string GetAccessToken(string uname, string password)
        {
            Guid g;

            try
            {
                uname = Decryptdata(uname);
                password = Decryptdata(password);
                if (!String.IsNullOrEmpty( uname)  && !String.IsNullOrEmpty( password)) {
                    if (uname.Equals("vishwas", StringComparison.CurrentCultureIgnoreCase) && password.Equals("anand", StringComparison.CurrentCultureIgnoreCase))
                    {
                      
                        g = Guid.NewGuid();
                        accessToken = g.ToString().ToUpper();

                    }
                    else {
                        accessToken = String.Empty;
                    }
                }
            }
            catch (Exception ex) { 
            
            }
            return accessToken;
        
        }
    }

       
}
