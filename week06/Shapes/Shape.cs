public class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        SetColor(color);
        GetColor();
    }

    public virtual double GetArea()
    {
        return 0;
    }
}