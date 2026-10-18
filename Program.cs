
TemperatureSensor sensor = new TemperatureSensor();

Observer observerA = new Observer("A");
Observer observerB = new Observer("B");

Console.WriteLine("Dodaję obserwatora A");
sensor.AddObserver(observerA);

Console.WriteLine("Dodaję obserwatora B");
sensor.AddObserver(observerB);

Console.WriteLine("\nUstawiam temperaturę na 17C");
sensor.SetTemperature(17);

Console.WriteLine("\nUstawiam temperaturę na 32C");
sensor.SetTemperature(32);

Console.WriteLine("\nUsuwam obserwatora A");
sensor.RemoveObserver(observerA);

Console.WriteLine("\nUstawiam temperaturę na 24C");
sensor.SetTemperature(24);

Console.WriteLine("\nUsuwam obserwatora B");
sensor.RemoveObserver(observerB);

Console.WriteLine("\nUstawiam temperaturę na 25C");
sensor.SetTemperature(25);

Console.WriteLine("\nNaciśnij dowolny klawisz, aby zamknąć program...");
Console.ReadKey(true);