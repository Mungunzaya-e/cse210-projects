using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Online Orders --");
        Console.WriteLine();
        Console.WriteLine(new string('=', 60));

        List<Order> orderList = new List<Order>();

        Order order1 = new Order(new Customer("Brian Ludwig", new Address("Via Roma 93", "Borgo Stazione", "Asti", "Italy")));
        order1.AddProductToList(new Product("Craftsman Mechanics Tool Set", "T055", 99.00));
        order1.AddProductToList(new Product("FelixKing Office Chair", "C0234", 116.84, 2));
        orderList.Add(order1);

        Order order2 = new Order(new Customer("Isabel Saunders", new Address("13 Freedom Trail", "Boston", "MA", "United States")));
        order2.AddProductToList(new Product("21-key Thumb Piano Kalimba", "KAL021", 15.56, 2));
        order2.AddProductToList(new Product("Women's Taylor 1989 SweatShirt", "S546", 35.75));
        order2.AddProductToList(new Product("1 Pair French Vintage Earrings", "E03", 3.25, 5));
        orderList.Add(order2);

        Order order3 = new Order(new Customer("Carol Figgs", new Address("Moe's Tavern, 555 S Main St", "Los Angeles", "CA", "United States")));
        order3.AddProductToList(new Product("QEEIG Bathroom Shelves", "S129", 26.81));
        order3.AddProductToList(new Product("Cotton Throw Blanket for Couch Soft", "B789", 18.89, 3));
        order3.AddProductToList(new Product("Origami Paper, Pack of 200 Sheets", "OP56", 6.25, 10));
        orderList.Add(order3);

        int i = 0;
        foreach (Order order in orderList)
        {
            Console.WriteLine($"\nORDER - {i + 1}\n");
            Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}\n");
            Console.WriteLine($"Shipping Label:\n\t{order.GetShippingLabel()}\n");
            Console.WriteLine($"Total Cost: {order.GetTotalCost()}$\n");
            Console.WriteLine(new string('=', 60));

            i++;
        }
    }
}