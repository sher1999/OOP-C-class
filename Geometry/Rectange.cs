public class Rectange{
   public double With;
   public double Height;
   public string Color;

    public void GetArea(double With, double Height, string Color){

       Console.WriteLine( $"Area of a rectange : {With*Height}" );
       Console.WriteLine($"Color : {Color}");
    }
    public void GetPerimeter(double With, double Height, string c){

       Console.WriteLine( $"Perimeter of a rectange : {(With+Height)*2}" );
       Console.WriteLine($"Color : {Color}");
    }


    
}