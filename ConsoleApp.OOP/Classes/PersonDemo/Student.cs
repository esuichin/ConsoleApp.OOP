using ConsoleApp.OOP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP.Classes.PersonDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            //_idNumber = "STU-" + GetRandomNumber();
            _idNumber = PersonHelper.GenerateIdNumber("STU");


        }
    }
}
