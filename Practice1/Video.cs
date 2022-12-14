public class Video{
    public string _tittle;
    public string _author;
    public int _timeSeconds;
    public Comment _listComment;

    public void getInfoVideo(){
        Console.WriteLine("------------------------------");
        Console.WriteLine("Title Video: " + _tittle);
        Console.WriteLine("Author Video: " + _author);
        Console.WriteLine("Video length: " + _timeSeconds + " seconds.");
        Console.WriteLine("COMMENTS");
        Console.WriteLine(_listComment._author1 +": " +_listComment._comment1);
        Console.WriteLine(_listComment._author2 +": " +_listComment._comment2);
        Console.WriteLine(_listComment._author3 +": " +_listComment._comment3);
        Console.WriteLine("-------------------------");
        Console.WriteLine("");
    }

}