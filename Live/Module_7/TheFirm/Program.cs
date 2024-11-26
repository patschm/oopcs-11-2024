namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        Adil a1 = new Adil();
        Engjell e1 = new Engjell();
        Ruben r1 = new Ruben();
        Sercan s1 = new Sercan();
        ACME acme = new ACME();
        Bokito b1 = new Bokito();
        acme.Hire(a1);
        acme.Hire(e1);
        acme.Hire(r1);
        acme.Hire(b1);

        acme.Start();
    }
}
