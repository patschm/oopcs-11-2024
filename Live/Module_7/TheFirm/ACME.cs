namespace TheFirm;

internal class ACME
{
    private IContract[] werknemers = new IContract[5];

    public void Hire(IContract employee)
    {
        for(int i = 0; i < werknemers.Length; i++)
        {
            if (werknemers[i] == null)
            {
                werknemers[i] = employee;
                return;
            }
        }
    }

    public void Start()
    {
        Console.WriteLine("ACME Gaat produceren");
        foreach(IContract emp in werknemers)
        {
            emp?.Werken();
        }
    }
}
