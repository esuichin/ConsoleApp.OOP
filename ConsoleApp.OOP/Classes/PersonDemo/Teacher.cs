using ConsoleApp.OOP.Utils;

namespace ConsoleApp.OOP.Classes.PersonDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            //_idNumber = "TCH-" + GetRandomNumber();
            _idNumber = PersonHelper.GenerateIdNumber("TCH");
        }       
    }
}
