public class Circle{
  public double Radius;
  public string Color;
  public const double pi=3.14;
  public void GetArea(double Radius,string Color){
    const double pi=3.14;
    Console.WriteLine( $"Area of a circle : {pi*Radius*Radius}" );
       Console.WriteLine($"Color : {Color}");
  }
  public void GetCircumference(double Radius,string Color){
    const double pi=3.14;
    Console.WriteLine( $"Circumferenceof a circle : {2*pi*Radius}" );
       Console.WriteLine($"Color : {Color}");
  }
   


}