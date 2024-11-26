﻿namespace DeFlat;

internal class Lift
{
    public int CurrentFloor { get; private set; }

    public void Call(int floor)
    {
        Console.WriteLine($"De lift zoemt naar de {floor}e verdieping");
        CurrentFloor = floor;
    }
}
