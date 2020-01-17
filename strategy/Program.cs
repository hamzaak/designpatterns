using System;
using System.Collections.Generic;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prepare strategies
            var normalStrategy = new NormalStrategy();
            var happyHourStrategy = new HappyHourStrategy();

            var firstCustomer = new Customer(normalStrategy);

            // Normal billing
            firstCustomer.Add(1.0, 1);

            // Start Happy Hour
            firstCustomer.Strategy = happyHourStrategy;
            firstCustomer.Add(1.0, 2);

            // New Customer
            Customer secondCustomer = new Customer(happyHourStrategy);
            secondCustomer.Add(0.8, 1);
            // The Customer pays
            firstCustomer.PrintBill();

            // End Happy Hour
            secondCustomer.Strategy = normalStrategy;
            secondCustomer.Add(1.3, 2);
            secondCustomer.Add(2.5, 1);
            secondCustomer.PrintBill();

            Console.ReadKey();
        }
    }

    class Customer
    {
        private IList<double> drinks;

        // Get/Set Strategy
        public IBillingStrategy Strategy { get; set; }

        public Customer(IBillingStrategy strategy)
        {
            this.drinks = new List<double>();
            this.Strategy = strategy;
        }

        public void Add(double price, int quantity)
        {
            this.drinks.Add(this.Strategy.GetActPrice(price * quantity));
        }

        // Payment of bill
        public void PrintBill()
        {
            double sum = 0;
            foreach (var drinkCost in this.drinks)
            {
                sum += drinkCost;
            }
            Console.WriteLine($"Total due: {sum}.");
            this.drinks.Clear();
        }
    }

    interface IBillingStrategy
    {
        double GetActPrice(double rawPrice);
    }

    // Normal billing strategy (unchanged price)
    class NormalStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice) => rawPrice;
    }

    // Strategy for Happy hour (50% discount)
    class HappyHourStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice) => rawPrice * 0.5;
    }
}
