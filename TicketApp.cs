/*the purpose of this class to model a ticket and display fine to violator
Author:Ajima Master
Date:1/3/21
*/

using System;
using System.IO;
    

namespace SpeedingTicket
{
      public class Fine
      {
            private Random rnd=new Random();
    
            
               // create an object ticket to call method 
                  Ticket ticket=new Ticket();
                   //string studentNumbre="Ajima";
                  int speed=1;
                  int ticketSpeed;
                  bool studentNumbre=true;
                  public string InputStudentNumber{get;}
                  public char yrInschool{get;set;}
                  //public int speed{get;set}

                   public  Fine(string no,char classif,int speed)
                  {
                      no= studentNumbre.ToString() ;
                      this.yrInschool=classif;
                      this.ticketSpeed=speed;

                                      //int speedLimit;
                  

                  }
                  //int speedLimit;
                   string InputNumbre(int yrInschool)
                  {
                         int no=100000+rnd.Next(900000);
                         return Convert.ToString(no);
                  }
                  char InputYearInSchool(){
                     Console.WriteLine("Please enter year in classification");
                     
                     return yrInschool;
                  }
    
                  

                  
         }

            
      }        

     
     
     //declare a variable for student number
        


        
       



    




