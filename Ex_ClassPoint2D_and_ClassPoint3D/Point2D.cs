namespace Ex_ClassPoint2D_and_ClassPoint3D;

public class Point2D
{
    private float x, y =0.0f;
    
    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public Point2D()
    {
        this.x = 0.0f;
        this.y = 0.0f;
    }

    public float GetX()
    {
        return this.x;
    }
    public float GetY()
    {
        return this.y;
    }
    public void SetX(float x)
    {
        this.x = x;
    }
    public void SetY(float y)
    {
        this.y = y;
    }
    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    //+Get XY():float[2] , float[2] Array of{X,Y}
    public float[] GetXY()
    {
        float[] xy = new float[2];
        xy[0] = this.x;
        xy[1] = this.y;
        return xy;
    }
public override string ToString()
    {
        return $"({this.x},{this.y})";
    }
}