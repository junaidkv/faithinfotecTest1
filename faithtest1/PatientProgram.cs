using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faithinfotecttest1
{
    struct Patient
{
        
        public String patientRegisterNumber, patientName, patientDateofbirth, patientGender, patientAddress, patientPhoneNumber;
    
} ;
    //class Handling
    //{
    //    public Patient[] patientArray = new Patient[6];
    //    public int patientCount = 0;

    //    public void addPatient()
    //    {
    //        System.Console.WriteLine("enter reg no:");
    //        patientArray[patientCount].patientRegisterNumber = Console.ReadLine();
    //        System.Console.WriteLine("enter patientName:");
    //        patientArray[patientCount].patientName = Console.ReadLine();
    //        System.Console.WriteLine("enter patientDateofbirth");
    //        patientArray[patientCount].patientDateofbirth = Console.ReadLine();
    //        System.Console.WriteLine("enter patientGender");
    //        patientArray[patientCount].patientGender = Console.ReadLine();
    //        System.Console.WriteLine("enter patientAddress");
    //        patientArray[patientCount].patientAddress = Console.ReadLine();
    //        System.Console.WriteLine("enter patientPhoneNumber:");
    //        patientArray[patientCount].patientPhoneNumber = Console.ReadLine();
    //        System.Console.WriteLine("\n \n thank you ! \n");
            


    //        System.Console.WriteLine("reg no:" + patientArray[patientCount].patientRegisterNumber);
    //        System.Console.WriteLine("name:" + patientArray[patientCount].patientName);
    //        //patientCount = patientCount + 1;
            
    //    }
    //    public void displayPatient()
    //    {
    //        for (int i = 0; i <= patientCount; i++)
    //        {
    //            System.Console.WriteLine("reg no:"+patientArray[i].patientRegisterNumber );
    //            System.Console.WriteLine("patientName:", patientArray[i].patientName);
    //            System.Console.WriteLine("patientDateofbirth:", patientArray[i].patientDateofbirth);
    //            System.Console.WriteLine("patientGender:", patientArray[i].patientGender);
    //            System.Console.WriteLine("patientAddress:", patientArray[i].patientAddress);
    //            System.Console.WriteLine("patientPhoneNumber:", patientArray[i].patientPhoneNumber);
    //        }
    //    }

    //}
    class Program
    {
        
        static void Main(string[] args)
        {
            int i, n ;
           // Handling firstobject= new Handling();
             Patient[] patientArray = new Patient[100];
                int patientCount = 0;
            int choice=0;
            while(choice!=3)
            {
                System.Console.WriteLine("pleace choose your option: \n press 1 : Add patient \n press 2: List all patient \n press 3: exit  \n\n please enter your choice : ");
               choice= Convert.ToInt32(Console.ReadLine());
               switch (choice)
               {
                   case 1:
                       if (patientCount < 100)
                       {
                           System.Console.WriteLine("enter reg no:");
                           patientArray[patientCount].patientRegisterNumber = Console.ReadLine();
                           System.Console.WriteLine("enter patientName:");
                           patientArray[patientCount].patientName = Console.ReadLine();
                           System.Console.WriteLine("enter patientDateofbirth");
                           patientArray[patientCount].patientDateofbirth = Console.ReadLine();
                           System.Console.WriteLine("enter patientGender");
                           patientArray[patientCount].patientGender = Console.ReadLine();
                           System.Console.WriteLine("enter patientAddress");
                           patientArray[patientCount].patientAddress = Console.ReadLine();
                           System.Console.WriteLine("enter patientPhoneNumber:");
                           patientArray[patientCount].patientPhoneNumber = Console.ReadLine();
                           System.Console.WriteLine("\n \n thank you ! \n");
                           patientCount = patientCount + 1;
                       }
                       else
                       {
                           System.Console.WriteLine("patient list full");
                       }



            
                       //firstobject.addPatient();
                       //firstobject.patientCount = firstobject.patientCount + 1;
                       break;
                   case 2:
                       for ( i = 0; i <patientCount; i++)
                       {
                           //System.Console.WriteLine("patientPhoneNumber:" + patientArray[i].patientPhoneNumber);
                           System.Console.WriteLine("\n reg no:" + patientArray[i].patientRegisterNumber);
                           System.Console.WriteLine("patientName:"+ patientArray[i].patientName);
                           System.Console.WriteLine("patientDateofbirth:"+patientArray[i].patientDateofbirth);
                           System.Console.WriteLine("patientGender:"+ patientArray[i].patientGender);
                           System.Console.WriteLine("patientAddress:"+ patientArray[i].patientAddress);
                           System.Console.WriteLine("patientPhoneNumber:"+patientArray[i].patientPhoneNumber);

                           
                       }
                       System.Console.WriteLine("\n\n");
                       //firstobject.displayPatient();
                       break;

                   default:
                       System.Console.WriteLine("\n *****pleace choose valid option*****\n");
                       break;
               }

 


               }
            }


    }
        }
    

