using System;

namespace BoilerPlate {

    class FramePlate {

        // Global var...

        static void Main( string[] args ) {
            Console.WriteLine('Welcome to Frameplate application in CSharp.');
            MyName();
        }

        static string MyName() {
            Console.WriteLine('Please, enter your name: ');

            string userName = Console.ReadLine();
            Console.WriteLine('Welcome! Your name is ' + userName);
        }
    }
}