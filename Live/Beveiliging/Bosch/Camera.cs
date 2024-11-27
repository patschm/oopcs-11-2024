using Yunex;

namespace Bosch;

public class Camera : IObserver
{
    public void Detecting()
    {
        Start();
    }

    public void Start()
    {
        Console.WriteLine("De camera neemt het tafereel op");
    }
}
