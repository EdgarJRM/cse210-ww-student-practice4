public class Customer{
    public string _nameClient;
    public Address _addressClient;
    public Product _product1;
    public Product _product2;

    public int GetLiveUSA(){
        if (_addressClient.GetCountry() == "USA"){
            return 5;
        }else{
            return 35;
        }
    }
}