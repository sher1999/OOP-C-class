public class Shape{
    public void GetPosition(double x, double y){
        Console.WriteLine($"Position ({x} {y});" );
    }
    
    public void GetFullInfo(string c , string n, double x, double y){
        Console.WriteLine($"Color {c}, Name {n}, Position ({x} {y});" );
    }

}