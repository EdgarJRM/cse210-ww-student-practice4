public class Activity{
    private string _date;
    private string _type;
    private double _time;
    private double _distance = - 1;
    


    public void SetActivity(string type, string date, double time){
        _type = type;
        _date = date;
        _time = time;
    }
    public void SetDistance(double distance){
        _distance = distance;
    }

    public virtual double GetDistance(){
        return _distance;
    }
    public virtual double GetSpeed (){
        return (_distance / _time) * 60;
    }
    public virtual double GetPace(){
        return _time / _distance;
    }

    public double GetTime(){
        return _time;
    }

    public void GetSummary(){
        Console.WriteLine (_date + " " + _type + " (" + _time + " min): Distance " + GetDistance() + "km, Speed " + GetSpeed() + "kph, Pace: " + GetPace() + " min per km");
        Console.WriteLine ();
    }

}  