namespace Ex_ClassPoint2D_and_ClassPoint3D;

public class Point3D:Point2D
{
    private float z = 0.0f;
    public Point3D(float x, float y, float z):base(x,y)
    {
        this.z = z;
    }
    public Point3D():base()
    {
        this.z = 0.0f;
    }
    public float GetZ()
    {
        return this.z;
    }
    public void SetZ(float z)
    {
        this.z = z;
    }
    public void SetXYZ(float x, float y, float z)
    {
        base.SetXY(x,y);
        this.z = z;
    }
    public float[] GetXYZ()
    {
        float[] xyz = new float[3];
        xyz[0] = base.GetXY()[0];
        xyz[1] = base.GetXY()[1];
        xyz[2] = this.z;
        return xyz;
    }
    public override string ToString()
    {
        return $"({base.GetXY()[0]},{base.GetXY()[1]},{this.z})";
    }
}