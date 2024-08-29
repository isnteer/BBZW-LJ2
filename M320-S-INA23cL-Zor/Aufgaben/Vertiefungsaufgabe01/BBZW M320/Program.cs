namespace BBZW_M320;

class Program
{
    static void Main() 

    { 
        Zylinder z1 = new Zylinder(); 
        z1.setDurchmesser(10.5); 
        z1.setHoehe(20.5); 
        double v1 = z1.getVolumen(); 
        double a1= z1.getGrundflaeche() ; 
        double m1 = z1.getMantelflaeche(); 
        double o1 = z1.getOberflaeche();
        Console.WriteLine("Zylinder 01: Volumen = " + v1.ToString() + " Oberflaeche = " + o1.ToString());
        //--------------------------------------------- 
        Zylinder z2 = new Zylinder(30.0, 15.5);   //Param1 = Durchmesser, Param2 = Höhe 
        double o2 = z2.getOberflaeche(); 
        double v2 = z2.getVolumen();
        Console.WriteLine("Zylinder 02: Volumen = " + v2.ToString() + "Oberflaeche = " + o2.ToString() ); 
        //--------------------------------------------- 
        double o3 = Zylinder.getOberflaeche(50.5, 20.0);   //Param1 = Durchmesser, Param2 = Höhe 
        Console.WriteLine("Zylinder 03: Oberflaeche = " + o3.ToString()); 
        //--------------------------------------------- 
        Console.ReadLine(); 
    } 
}

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
