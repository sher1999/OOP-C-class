public class Shape{
     public string Color;
      public string Name;
    public double PositionX;
    public double PositionY;
    public void GetPosition(double PositionX, double PositionY){
        Console.WriteLine($"Position ({PositionX} {PositionY});" );
    }
    
    public void GetFullInfo(string Color , string Name, double PositionX, double PositionY){
        Console.WriteLine($"Color {Color}, Name {Name}, Position ({PositionX} {PositionY});" );
    }

}