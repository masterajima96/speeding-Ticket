/*Initiate a Tickit object from input value of Tickit class
Author:Ajima Master
Date:2/4/21
File Name:TicketApp.cs

 */
using System;
namespace TicketSpace
{
   public class TicketApp
   {
      static void Main( )
      {
           int speedLimit,
               speed;
           char classif;
           //access method InputSpeed to establish speed violate
           speedLimit = InputSpeed("Speed Limit", out speedLimit);
           speed = InputSpeed("Ticketed Speed", out speed);
           //
           classif = InputYearInSchool( );
           Ticket myTicket = new Ticket(speedLimit, speed);
           myTicket.SetFine(classif);
           Console.WriteLine("Fine: {0:C}", myTicket.Fine);
      }

      //method to check for street speed

      public static int InputSpeed(string whichSpeed, out int s)
      {
           string inValue;
           Console.Write("Enter the {0}: ", whichSpeed);
           inValue = Console.ReadLine();
           s = Convert.ToInt32(inValue);
           return s;
      }

      //method to input category of violator
public static char InputYearInSchool ( )
      {
           string inValue;
           char yrInSchool;

           Console.WriteLine("Enter your classification:" );
           Console.WriteLine("\tFreshmen (enter 1)");
           Console.WriteLine("\tSophomore (enter 2)");
           Console.WriteLine("\tJunior (enter 3)");
           Console.Write("\tSenior (enter 4)");
           Console.WriteLine();
           inValue = Console.ReadLine();
           yrInSchool = Convert.ToChar(inValue);
           return yrInSchool;
       }   // End InputYearInSchool( ) method
    }  //  End TicketApp class
} // End TicketSpace namespace
