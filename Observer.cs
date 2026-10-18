using System;

public class Observer : IObserver
{
    private readonly string _name;

    public Observer(string name)
    {
        _name = name;
    }

    public void Update(double temperature)
    {
        Console.WriteLine(
            $"Observer {_name}: Temperatura zmieniła się na {temperature} C"
        );
    }
}