﻿using Yunex;

namespace Heras;

public class Hek: IObserver
{
    public void Detecting()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
