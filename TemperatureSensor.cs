
using System;
using System.Collections.Generic;

public class TemperatureSensor
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    private double _temperature;

    public double Temperature
    {
        get { return _temperature; }
    }

    public void AddObserver(IObserver observer)
    {
        if (observer == null)
        {
            throw new ArgumentNullException(nameof(observer));
        }

        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetTemperature(double temperature)
    {
        if (_temperature == temperature)
        {
            return;
        }

        _temperature = temperature;

        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}
