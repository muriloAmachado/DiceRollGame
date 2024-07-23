var retangle1 = new Retangle();

retangle1.Width = 5;

Console.WriteLine(retangle1.printWidth());

class Retangle {
    public int Width;
    int Height;

    public int printWidth(){
        return Width;
    }
}

