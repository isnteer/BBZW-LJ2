namespace BBZW_M320;

public class Zylinder
{
    private double durchmesser;
    private double hoehe;
    private const double PI = 3.141592653589793;

    public Zylinder()
    {
        durchmesser = 1.0;
        hoehe = 1.0;
    }

    public Zylinder(double durchmesser, double hoehe)
    {
        this.durchmesser = durchmesser;
        this.hoehe = hoehe;
    }

    public void setDurchmesser(double durchmesser)
    {
        this.durchmesser = durchmesser;
    }

    public void setHoehe(double hoehe)
    {
        this.hoehe = hoehe;
    }

    public double getVolumen()
    {
        double radius = durchmesser / 2;
        return PI * radius * radius * hoehe;
    }

    public double getGrundflaeche()
    {
        double radius = durchmesser / 2;
        return PI * radius * radius;
    }

    public double getMantelflaeche()
    {
        double radius = durchmesser / 2;
        return 2 * PI * radius * hoehe;
    }

    public double getOberflaeche()
    {
        return getGrundflaeche() * 2 + getMantelflaeche();
    }

    public static double getOberflaeche(double durchmesser, double hoehe)
    {
        Zylinder temp = new Zylinder(durchmesser, hoehe);
        return temp.getOberflaeche();
    }
}
