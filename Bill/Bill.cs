using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    //class Bill
    public class Bill
    {
        public int invoice;
        public DateTime dateInvo;
        public int number_care;
        public string name_driver;
        //Driver_ratio is Fixed
        public double Driver_ratio= 0.10;
        //Company_ratio is Fixed
        public double Company_ratio = 0.90;




        //  EnterTheBill way and interface to explain to the user what he should enter
        public void EnterTheBill()
        {
            Console.WriteLine("Enter the number invoice please:");
            invoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date invoice please:");
            dateInvo = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number care please:");
            number_care = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name driver please:");
            name_driver = Console.ReadLine();


        }
    }

    //class Cash_Bill
    class Cash_Bill : Bill
    {
        public double Weight;
        public double distance;
        //TheFareIsEvery1Km is Fixed
        public double TheFareIsEvery1Km = 8000;
        public double Natural_wages;


        // CalculateFullFare To calculate Natural wages, weight and distance
        public double CalculateFullFare()
        {
            if (distance <= 25)
            {
                Natural_wages = distance * TheFareIsEvery1Km;

                return Natural_wages;

            }
            if (distance > 26 && distance < 60)
            {
                Natural_wages = 25 * TheFareIsEvery1Km;

                Natural_wages = Natural_wages + ((distance - 25) * 10000);


                if (Weight > 1000)
                {
                    Natural_wages = Natural_wages + (Weight - 1000) * 1000;

                }
            }
            if (distance >= 60)
            {
                Natural_wages = 59 * TheFareIsEvery1Km;

                Natural_wages = Natural_wages + ((distance - 59) * 12000);

                if(Weight > 1200)
                {
                    Natural_wages = Natural_wages + (Weight - 1200) * 1500;

                }
            }
            return Natural_wages;
        }


    }

    //class Forward_Bill 
    class Forward_Bill : Cash_Bill
    {
        public string Client_Name;
        //discount is Fixed
        public double discount = 0.10;
        public double full_discount;

        // CalculateDiscount to calculate the discount
        public double CalculateDiscount(int NumberTrips)
        {
            if (NumberTrips == 2)
            {
                discount = 0.10;
            }
            else if(NumberTrips == 3)
            {
                discount = 0.15;
            }
            else if (NumberTrips >= 4)
            {
                discount = 0.20;
            }
            else
            {
                Console.WriteLine("There is no more discount, only a fixed discount of 10 percent for one trip");
            }
            return discount;
        }

        //class Payment     
    }
    class Payment
    {
        public int number_payment;
        public DateTime date_payment;
        public int value_payment;
        public string Reason_for_exchange;

        //EnterThePayment way and interface to explain to the user what he should enter
        public void EnterThePayment()
        {
            Console.WriteLine("Enter the number payment please:");
            number_payment = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the date payment please:");
            date_payment = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value payment please:");
            value_payment = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Reason for exchange please:");
            Reason_for_exchange = Console.ReadLine();

        }
    }
}
