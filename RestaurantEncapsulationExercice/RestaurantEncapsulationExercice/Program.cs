using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercice
{
        public class Meal
        {//--------------------------------------------Start of Meal----------------------------------------------------
            public string name;
            public decimal price;
            public decimal cost;

            public void addMeal(string name, decimal price, decimal cost)
            {
                this.name = name;
                this.price = price;
                this.cost = cost;
            }
            public static void cookMeal(Meal meal)
            {
                Console.WriteLine("The meal {0} has been cooked.", meal.name);
            }

        }//--------------------------------------------End Of Meal---------------------------------------------------
        public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
        }//end takeOrder
       
    }//------------------------------------------End of Order--------------------------------------------------

    public class Balance
    {

        public static decimal balance = 0;

        public static decimal adjustBalance(Meal meal)
        {
            Balance.balance = balance + meal.price;
            balance = balance - meal.cost;
            return balance;
        }//end adjust balance
             
  
    }//------------------------------------------End of balance--------------------------------------------------
    class Program
    {
        static void Main(string[] args)
    
        {

            decimal totalBalance = 0;

            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);

            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);

            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);

            //taking an order, cooking the meal and adjusting the accounts
            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            totalBalance += Balance.adjustBalance(steak);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            totalBalance += Balance.adjustBalance(pumpkinRisotto);

            //total of money the restaurant has made
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", totalBalance);
        }
}//--------------------------------------------End Of Program----------------------------------------
        
}//--------------------------------------------End Of NameSpace----------------------------------------
        