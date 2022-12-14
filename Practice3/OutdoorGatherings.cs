public class OutdoorGatherings: Events {
    private string _weather;

    public void SetWeather (string weather){
        _weather = weather;
    }
    public string GetWeather (){
        return _weather;
    }
           
}