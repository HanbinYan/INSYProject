using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSYProject
{
    internal class Child
    {
        private string _name;
        private string _personInCharge;
        private double _age;
        private string _phoneNumber;
        private int _childID;


        public Child(string name, string personInCharge, double age, string phoneNumber, int childID)
        {
            _name = name;
            _personInCharge = personInCharge;
            _age = age;
            _phoneNumber = phoneNumber;
            _childID = childID;
        }


    }
}
