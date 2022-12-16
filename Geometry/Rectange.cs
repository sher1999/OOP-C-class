public class Rectange{
    public void GetArea(double w, double h, string c){

       Console.WriteLine( $"Area of a rectange : {w*h}" );
       Console.WriteLine($"Color : {c}");
    }
    public void GetPerimeter(double w, double h, string c){

       Console.WriteLine( $"Perimeter of a rectange : {(w+h)*2}" );
       Console.WriteLine($"Color : {c}");
    }


    
}