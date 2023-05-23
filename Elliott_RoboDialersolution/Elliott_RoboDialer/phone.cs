using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_RoboDialer
{
    internal abstract class phone
    {

        private bool _iscell;

        public bool iscell
        {
            get { return _iscell; }
            set { _iscell = value; }
        }



        private string _number;

        public string number
        {
            get { return _number; }
            set { _number = value; }
        }

        private string _company;

        public string selectedcompany
        {
            get { return _company; }
            set { _company = value; }
        }



        public phone (string phonenumber, string company, int cellcheck) 
        {
            _number = phonenumber;
            _company = company;
            if (cellcheck == 1)
            {
                _iscell= false;
            }
            else
            {
                _iscell= true;
            }
        } 

        public virtual string dial()
        {

            string dialstring = _company+" is being dialed using "+_number+" . . . \n";
            return dialstring;
        }

    }
}
