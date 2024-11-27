﻿namespace Yunex;

public class DetectieLus
{
    private IObserver[] devices = new IObserver[10];

    public void Connect(IObserver device)
    {
        for(int i = 0; i < devices.Length; i++)
        {
            if (devices[i] == null)
            {
                devices[i] = device;
                return;
            }
        }
    }

    public void Detect()
    {
        Console.WriteLine("De detectielus ziet wat");

        foreach(IObserver dev in devices)
        {
            dev?.Detecting();
        }
    }
}