/*write a console applition to determine fine associated with ticket on campus
purpose of this programme to create speeding ticket application
Date:15/3/21
Author:Ajima Master*/
//using system is system class library
using System;
//
using System.Collections.Generic;
namespace SpeedingTicket{


public class Ticket
{

        //Initiate random object randomly genrate student number
        
        //wheather junior,senior,sophomore allocate 0,1,2,3
        private static string NameOfClassification="senior";
            //street speed limit
       public int speedLimit;
             //speed over speed limit
       public int speed;
             // classification of student
        string yrInschool;
             //name of violator
      public  string studentNumbre;
       public int fine;
        int ticket;

   
    //street speed limit
    
    
  //classification of student
  
  
    public string yrInSchool{get;}
    
    //public int fine{get;}    

        
  
  //
    public int GetFine(int fine)
    {
      
          return fine;
      }
  public void SetFine(int fine){
      this.ticket=fine;
  }
  

/*create constructor initialize ticket with information provided by user*/
public void TicketApp(string no,int speedTravelling,string classif)
{
    this.studentNumbre=no;
    this.speed=speedTravelling;
    this.yrInschool=classif;
    this.yrInschool=NameOfClassification.ToString();
   //Convert.ToInt32(NameOfClassification)++;
}
    



   // private List<Ticket> allfine=new List<Ticket>;

    /*get no of student by accessor*/
    public int getstudentNumber(int no){
        return no;
    }
    //set value of student no
    public void setStudentNumber(string no){
    this.studentNumbre=no;
    }

    public int getSpeed()
    {
        return speed;
    }
    public void setSpeed(int speed)
    {
        this.speed=speed;
    }

    //get speedlimit violator gone under
    public int getSpeedLimit()
    {
        return speedLimit;
    }
         //establish violator has gone under using set
        public void setSpeedLimit(int speedLimit )
        {
          this.speedLimit=speedLimit;
        }
        
        //identify violator by classification
        public string getYrInschool(string yrInschool)
        {
         return yrInschool;
        }
            public void setYrInschool(string yrInschool)
            {
                this.yrInschool=yrInschool;
            }
            
            
            public void Setfine(int fine){
                this.ticket=fine;
            }

            
    
    /*method SetFine will calculate fine based on classification of violator*/
    public void CalculateFine(int speed,int ticketedSpeed,int rank)
    {

        //declare variable
        
        int NameOfClassification=1234;
        this.speed=NameOfClassification;
        int fine;
        this.speedLimit=speed;
        this.studentNumbre= Convert.ToString(rank);
        
         
         //
            speed=ticketedSpeed-speedLimit;
            double val=87.50;
            fine=Convert.ToInt32(val);
            fine=(speed/5*fine)+fine;
           
           // if violator is senior than charge extra 50$
            if(NameOfClassification==3)
            {
                    if(speed>20)
                    {
                        fine=+200;
                    }
                    else
                    {
                       fine=+50;
                    
                    }
                    if(NameOfClassification==1)
                    {
                         if(speed<20)
                        {
                            fine=fine-50;
                        }
                        else
                         {
                                if(speed>20)
                                {
                                fine=+100;
                                }
                         
                             //fine=+100;
                    
                            
                                if(speed>19)
                                {
                                    fine=+100;
                                }
                         }
                    }       
            }

        Console.WriteLine("total fine is {0} and {1}" +fine);
    }
    
    
                         }
                    }
//string representation of ticket that return 

  /* public string ToString(string no )
    {
        return "studentNumbre:" +no+ "Speed:" + speed
        + "speed limit:" + speedLimit
        + "classification:" + yrInschool
        + "fine" + fine
        + "" +NameOfClassification();


    }*/







