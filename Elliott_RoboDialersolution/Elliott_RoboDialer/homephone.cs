using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_RoboDialer
{
    internal class homephone : phone
    {

        public homephone(string phonenumber, string company, int cellcheck) : base(phonenumber, company, cellcheck) 
        {

            base.number = phonenumber;
            base.selectedcompany = company;
            if (cellcheck == 1)
            {
                iscell = false;
            }
            else
            {
                iscell = true;
            }


        }

        public override string dial()
        {

            string dialstring = this.selectedcompany + " is being dialed using " + this.number + " . . . \n";
            return dialstring;
        }

    }
}
