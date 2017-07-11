using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("Sny", "Sony");
            stocks.Add("Fndr", "Fender");
            stocks.Add("Mcrsft", "Microsoft");
            stocks.Add("Apl", "Apple");
            // Add a few more of your favorite stocks


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "Sny", shares: 32, price: 17.87));
            purchases.Add((ticker: "Fndr", shares: 110, price: 43.32));
            purchases.Add((ticker: "Apl", shares: 64, price: 29.89));
            purchases.Add((ticker: "Fndr", shares: 21, price: 10.73));
            purchases.Add((ticker: "Mcrsft", shares: 69, price: 69.69));


            foreach((string ticker, int shares, double price) purchase in purchases) {
                //Console.WriteLine($"{purchase.ticker} {purchase.shares} {purchase.price}");
            }

            Dictionary<string, double> valuations = new Dictionary<string, double>();
            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases) { 
                string companyName = stocks[purchase.ticker];
                //Console.WriteLine($"current company in val loop: {companyName}");

                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                if (valuations.ContainsKey(companyName)) {
                    // add the value to the exisiting value
                    valuations[companyName] += (purchase.shares * purchase.price);
                }
                else {
                    // If not, add the new key and set its value
                    valuations.Add(companyName, (purchase.shares * purchase.price));
                }
            }
                // Print out valuePair as 
            foreach (KeyValuePair<string, double> valuePair in valuations) {
                Console.WriteLine(valuePair);
            }     
        }
    }
}
