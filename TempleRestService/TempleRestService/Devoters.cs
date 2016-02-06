using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempleRestService
{
    public class Devoters
    {
        string _id;
        string _doj;
        string _name;
        string _address;
        string _phoneno;
        string _age;

        

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        

        public string Phoneno
        {
            get { return _phoneno; }
            set { _phoneno = value; }
        }
        

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        

        public string Doj
        {
            get { return _doj; }
            set { _doj = value; }
        }
    }
}
