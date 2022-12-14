public class Order{

    public void StartGame(){
        Console.WriteLine ("Client 1");
        Customer customer1 = new Customer();
        customer1._nameClient = "Roy";
        customer1._addressClient = new Address();
        customer1._addressClient.SetDirection("7272 E Gage Ave", "Los Angeles", "California", "USA");
        customer1._product1 = new Product();
        customer1._product1.SetInfoProdut("Pizza", "000852", 20, 5);
        customer1._product2 = new Product();
        customer1._product2.SetInfoProdut("Pepsi", "000870", 2, 5);
        PackingLabel(customer1);
        ShippingLabel(customer1);
        Console.WriteLine ("");

        Console.WriteLine ("Client 2");
        Customer customer2 = new Customer();
        customer2._nameClient = "Luciano";
        customer2._addressClient = new Address();
        customer2._addressClient.SetDirection("Calle 60", "Barquisimeto", "Lara", "Venezuela");
        customer2._product1 = new Product();
        customer2._product1.SetInfoProdut("USB", "001852", 8, 300);
        customer2._product2 = new Product();
        customer2._product2.SetInfoProdut("Mouse", "003528", 30, 50);
        PackingLabel(customer2);
        ShippingLabel(customer2);
        Console.WriteLine ("");
    }

    public void PackingLabel(Customer customer){
        Console.WriteLine("Product1: ID" + customer._product1.GetNameId() + " " + customer._product1.GetpriceTotal() + "$");
        Console.WriteLine("Product2: ID" + customer._product2.GetNameId() + " " + customer._product2.GetpriceTotal() + "$");
        Console.WriteLine("Delivery = " + customer.GetLiveUSA() +"$");
        Console.WriteLine("Total = " + (customer._product1.GetpriceTotal() + customer._product2.GetpriceTotal() + customer.GetLiveUSA()) +"$");
    }

     public void ShippingLabel(Customer customer){
        Console.WriteLine("Send to: ");
        Console.WriteLine("Client: " + customer._nameClient);
        Console.WriteLine("Direction: " + customer._addressClient.GetDirection());
    }
    
}