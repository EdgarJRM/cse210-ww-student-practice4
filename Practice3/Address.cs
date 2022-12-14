public class Address{
    private string _streetAddress;
    private string _city;
    private string _state_province;
    private string _country;

    public void SetDirection(string streetAddress, string city, string state_province, string country){
        _streetAddress = streetAddress;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    public string GetDirection(){
        string direction = _streetAddress + ", " + _city + ", " + _state_province + ", " + _country;

        return direction;
    }

    public string GetCountry(){
       return _country;
    }
}