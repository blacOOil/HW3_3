using System;
using System.Collections.Generic;

class Program
{
    static void Main (string[] args)
    {
      Console.WriteLine("Input x,y : ");
       
        List<Tuple<double,double>> vertices = new List<Tuple<double,double>>();
    double x, y;
    
    do
    {
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        if (x != 0 && y != 0)
        {
            vertices.Add(new Tuple<double,double>(x,y));
        }
    } while (x != 0 || y != 0);

    Console.WriteLine("Input K point (x,y):");
    double tx = double.Parse(Console.ReadLine());
    double ty = double.Parse(Console.ReadLine());

    bool inside = false;
    int j = vertices.Count - 1;
    for (int i = 0; i < vertices.Count; i++)
    {
        if ((vertices[i].Item2 > ty) != (vertices[j].Item2 > ty) &&
            (tx < (vertices[j].Item1 - vertices[i].Item1) * (ty - vertices[i].Item2) / (vertices[j].Item2 - vertices[i].Item2) + vertices[i].Item1))
        {
            inside = !inside;
        }
        j = i;
    }

    if (inside)
    {
        Console.WriteLine("Inside");
    }
    else
    {
        Console.WriteLine("Outside");
    }
}
}