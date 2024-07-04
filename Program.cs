namespace hw_03_07_linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //            Завдання 3:
            //Створіть користувацький тип «Пристрій», який зберігатиме таку
            //інформацію:
            // назва пристрою;
            // виробник пристрою;
            // вартість.
            //Для двох масивів пристроїв реалізуйте операції:
            // різниця масивів;
            // перетин масивів;
            // об'єднання масивів.
            //Критерій для проведення операцій — виробник пристрою.

            Device[] devices1 = {new Device("device1","mfr1",100),
                                 new Device("device2","mfr",200),
                                 new Device("device3","mfr3",300),
                                 new Device("device4","mfr4",400) };

            Device[] devices2 = {new Device("device1","mfr1",100),
                                 new Device("device2","mfr2",200),
                                 new Device("device0","mfr0",10),
                                 new Device("device4","mfr4",400) };
            List<Device> result = new List<Device>();
            Console.WriteLine("різниця масивів;");
            result = devices1.Where(d1 => devices2.All(d2 => d2.Manufacturer != d1.Manufacturer)).ToList();
            foreach (var device in result)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine("перетин масивів;");
            result = devices1.Where(d1 => devices2.Any(d2 => d2.Manufacturer == d1.Manufacturer)).ToList();
            foreach (var device in result)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine("об'єднання масивів;");
            result = devices1.Union(devices2).ToList();
            foreach (var device in result)
            {
                Console.WriteLine(device);
            }

        }
    }
}
