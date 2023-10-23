using System;

namespace NeighborhoodBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            NeighborhoodInfo<int> neighborhood = new NeighborhoodInfo<int>();
            CustomerInfo customer = new CustomerInfo();

            try
            {
                Builder.CustomerInformation(customer);
                Builder.Build(neighborhood, customer);
            } catch
            {
                Console.WriteLine("You did something wrong.");
            }
        }
    }
}
