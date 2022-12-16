   System.Console.WriteLine();
   
   // A
 System.Console.WriteLine( "Rectange :");
Rectange rectange=new Rectange();
rectange.GetArea(2,2,"red");
rectange.GetPerimeter(2,2,"green");
System.Console.WriteLine();

    // B
    System.Console.WriteLine( "Circle :");
Circle carea=new Circle();
carea.GetArea(2,"black");
carea.GetCircumference(3,"orange");
System.Console.WriteLine();

    // C
System.Console.WriteLine("Shape");
Shape shape=new Shape();
shape.GetPosition(4,7);
shape.GetFullInfo("red","circle",5,7);
