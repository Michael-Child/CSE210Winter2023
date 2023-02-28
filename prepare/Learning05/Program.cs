using System;

class Program{
    static void Main(string[] args){
        List<Shape> shape = new List<Shape>{};
        var square = new Square();
        var circle = new Circle();
        var rectangle = new Rectangle();

        //Adding Color to each shape
        square.SetColor("Blue");
        circle.SetColor("Red");
        rectangle.SetColor("Green");

        //Adding Shapes to Shapes List
        shape.Add(square);
        shape.Add(circle);
        shape.Add(rectangle);

        foreach(var s in shape){
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}

class Shape{
    private string _color;
    public virtual double GetArea(){
        return 0;
    }public string GetColor(){
        return _color;
    }public void SetColor(string color){
        _color = color;
    }
}

class Square: Shape{
    private double _side = 5;
    public override double GetArea(){
        return Math.Pow(_side,2);
    }
}

class Circle: Shape{
    private double _radius = 5;
    public override double GetArea(){
        return Math.PI*Math.Pow(_radius,2);
    }
}

class Rectangle: Shape{
    private double _length = 4;
    private double _width = 6;
    public override double GetArea(){
        return _width*_length;
    }
}
