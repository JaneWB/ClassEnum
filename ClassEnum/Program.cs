using System;

namespace ClassEnum
{
    class Program
    {
        enum Student
        {
            Jane,
            Erik,
            Luke,
            LLew,
            Greg,
            Steven,
            Joshua,
            Courtney,
            Sue
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            //Student FirstName = (Student)Enum.Parse(typeof(Student), Console.ReadLine());
            string FirstName = Console.ReadLine();
            
                switch (FirstName)
            {
               case nameof(EnumList.Student.Jane):
                    Console.WriteLine("Brown");
                    break;
               case nameof(Student.Erik):
                    Console.WriteLine("Brown");
                    break;


            }

            Console.ReadLine();
            
        }
    }
}
