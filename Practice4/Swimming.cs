public class Swimming: Activity{
    private double _SwimmingLaps;

    public void SetSwimmingLaps(double SwimmingLaps){
        _SwimmingLaps = SwimmingLaps;
    }

    public override double GetDistance(){
        return _SwimmingLaps * 50 / 1000;;
    }

    public override double GetSpeed(){
        return (GetDistance() / base.GetTime() * 60);
    }

    public override double GetPace(){
        return 60 / GetSpeed();
    }
}