/*Purpose Of speeding tickit application to print overspeeding violator information
Ticket class is use to set fine
Author:Ajima Master
Date:13/3/21
File Name:Ticket.cs*/

//system namespaceto load classes and datatype
using System;
namespace TicketSpace
{
   public class Ticket
   {
      //declare cost variable to set ticket cost 
      private const decimal COST_PER_5_OVER = 87.50M;
      //street speed variable
      private int speedLimit;
      //speed over the speed limit
      private int speed;
      //violator get fine for over speeding
      private decimal fine;

      //create constructor to initialize object
      public Ticket( ){ }
            public Ticket(int speedLmt, int reportedSpeed)
      {
           speedLimit = speedLmt;
           speed = reportedSpeed - speedLimit;
      }
      //establish fine for over speeding for violator
      public decimal Fine
      {
           get
          {
             return fine;
          }
      }

     //calculate fine for classification of user
      public void SetFine(char classif)
      {
          //fine calculation
           fine = (speed / 5  * COST_PER_5_OVER) + 75.00M;
           //check case for senior violator
                     if (classif == '4')

               if (speed > 20)
                   fine += 200;
               else
                   fine += 50;
           else
           //for freshmen violator
               if (classif == '1')
                   if (speed < 21)
                       fine  -= 50;
                   else
                       fine += 100;
               else
                       if (speed > 20)
                           fine += 100;
        }   // End SetFine( ) method
    }  //  End Ticket class
} // End TicketSpace

