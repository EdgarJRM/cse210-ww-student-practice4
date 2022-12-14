public class Events {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private int _capacity;
    private string _typeOfEvent;
    public Address _addressEvent;

    public void SetEvent (string typeOfEvent, string title, string description, string date, string time, int capacity = 99999999){
        _typeOfEvent = typeOfEvent;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _capacity = capacity;
    }

    public string GetTypeEvent (){
        return _typeOfEvent;
    }
    public string GetTitle (){
        return _title;
    }
    public string GetFullDate (){
        return _date + " " + _time;
    }
    public string GetDescription (){
        return _description;
    }
    public int GetCapacity (){
        return _capacity;
    }
}