using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborhoodBuilder
{
    public class Builder
    {
        public static void CustomerInformation(CustomerInfo customer)
        {
            Console.WriteLine("Welcome to our neighborhood building service. Please enter your first and last name: ");
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Lastly, enter your ID.");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you, good luck building your neighborhood.\n\n\n");
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.ID = id;

        }
        public static void Build(NeighborhoodInfo<int> neighborhood, CustomerInfo customer)
        {
            double finalTax = 0;
            Console.WriteLine("Let's start building your neighbourhood. First of all, how many houses do you want your neighborhood to have?");
            Console.WriteLine("10: 2000$\n15: 3000$\n20: 3750$\n25: 4500$\n30: 5500$");
            int numberOfHouses = Convert.ToInt32(Console.ReadLine());
            switch (numberOfHouses)
            {
                case 10:
                    finalTax += 2000;
                    break;
                case 15:
                    finalTax += 3000;
                    break;
                case 20:
                    finalTax += 3750;
                    break;
                case 25:
                    finalTax += 4500;
                    break;
                case 30:
                    finalTax += 5500;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nOn a scale of 1 to 5, how good is the condition of the houses?");
            Console.WriteLine("1: 20% refund\n2: 10% refund\n3: No change in price\n4: +28%\n5: +40%");
            int conditionOfHouses = Convert.ToInt32(Console.ReadLine());
            switch (conditionOfHouses)
            {
                case 1:
                    finalTax -= finalTax * 0.2;
                    break;
                case 2:
                    finalTax -= finalTax * 0.1;
                    break;
                case 3:
                    break;
                case 4:
                    finalTax += finalTax * 0.28;
                    break;
                case 5:
                    finalTax += finalTax * 0.4;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nOn a scale of 1 to 5, how modern are the houses?");
            Console.WriteLine("1: 10% refund\n2: 5% refund\n3: No change in price\n4: +35%\n5: +50%");
            int modernityOfHouses = Convert.ToInt32(Console.ReadLine());
            switch (modernityOfHouses)
            {
                case 1:
                    finalTax -= finalTax * 0.1;
                    break;
                case 2:
                    finalTax -= finalTax * 0.05;
                    break;
                case 3:
                    break;
                case 4:
                    finalTax += finalTax * 0.35;
                    break;
                case 5:
                    finalTax += finalTax * 0.5;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nIs there a school in your neighborhood? If yes, how good is it on a scale of 1 to 5?");
            Console.WriteLine("There isn't (enter 'no'): No change in price\n1: 1500$\n2: 1900$\n3: 2600$\n4: 4000$\n5: 6500$");
            string isThereASchool = Console.ReadLine();
            switch (isThereASchool)
            {
                case "no":
                    break;
                case "1":
                    finalTax += 1500;
                    break;
                case "2":
                    finalTax += 1900;
                    break;
                case "3":
                    finalTax += 2600;
                    break;
                case "4":
                    finalTax += 4000;
                    break;
                case "5":
                    finalTax += 6500;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nOn a scale of 1 to 5, how good is the condition of the road & sidewalk?");
            Console.WriteLine("1: No change in price\n2: 250$\n3: 900$\n4: 1500$\n5: 2500$");
            int conditionOfRoad = Convert.ToInt32(Console.ReadLine());
            switch (conditionOfRoad)
            {
                case 1:
                    break;
                case 2:
                    finalTax += 250;
                    break;
                case 3:
                    finalTax += 900;
                    break;
                case 4:
                    finalTax += 1500;
                    break;
                case 5:
                    finalTax += 2500;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nOn a scale of 1 to 5, how is good the public transportation? (amount of bus stops, train stations, etc.)");
            Console.WriteLine("1: No change in price\n2: 500$\n3: 900$\n4: 1400$\n5: 2300$");
            int transportAvailability = Convert.ToInt32(Console.ReadLine());
            switch (transportAvailability)
            {
                case 1:
                    break;
                case 2:
                    finalTax += 500;
                    break;
                case 3:
                    finalTax += 900;
                    break;
                case 4:
                    finalTax += 1400;
                    break;
                case 5:
                    finalTax += 2300;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("\nOn a scale of 1 to 5, how friendly is the neighborhood (Welcoming community, low crime rates, etc.)?)");
            Console.WriteLine("1: 4500$ fine\n2: 1000$ fine\n3: No change in price\n4: 2000$\n5: 3500$");
            int friendliness = Convert.ToInt32(Console.ReadLine());
            switch (friendliness)
            {
                case 1:
                    finalTax -= 4500;
                    break;
                case 2:
                    finalTax -= 1000;
                    break;
                case 3:
                    break;
                case 4:
                    finalTax += 2000;
                    break;
                case 5:
                    finalTax += 3500;
                    break;
                default:
                    Console.WriteLine("You did something wrong.");
                    break;
            }
            Console.WriteLine("Congratulations, your neighborhood will be built shortly! Here is the overview of your neighborhood:");
            Console.WriteLine
            (
                $"Number of houses: {numberOfHouses}\n" +
                $"Condition of the houses: {conditionOfHouses}\n" +
                $"Modernity of the houses: {modernityOfHouses}\n" +
                $"School: {isThereASchool}\n" +
                $"Condition of the road/sidewalk: {conditionOfRoad}\n" +
                $"Public transport: {transportAvailability}\n" +
                $"Community friendliness: {friendliness}\n"
            );
            Console.WriteLine($"Your final tax is: {finalTax}. Since you are our 102431-st customer, you will get a 9% discount.");
            double finalTaxWithDiscount = finalTax - finalTax * 0.09;
            Console.WriteLine($"Final tax: {finalTaxWithDiscount}");
            Console.WriteLine($"Have a good day, {customer.FirstName}!");

        }
    }
}
