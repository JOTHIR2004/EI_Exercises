using Smart_Home_System.Core;
using Smart_Home_System.Devices;
using Smart_Home_System.Observer;
using Smart_Home_System.Scheduling;
using Smart_Home_System.Utils;

namespace Smart_Home_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hub = SmartHub.Instance;

            var light1 = DeviceFactory.CreateDevice("Light", 1);
            var thermo = (Thermostat)DeviceFactory.CreateDevice("Thermostat", 2);
            var door = new DoorLock(3);
            var doorProxy = new DoorLockProxy(door);
            var ac = new AC(4);
            var doorCamera = new DoorSensorCamera(5); 
            var cleaner = new HomeCleaner(6);

            hub.RegisterDevice(light1);
            hub.RegisterDevice(thermo);
            hub.RegisterDevice(doorProxy);
            hub.RegisterDevice(ac);
            hub.RegisterDevice(doorCamera);
            hub.RegisterDevice(cleaner);

            thermo.RegisterObserver(ac);           
            door.RegisterObserver(doorCamera);     

            Scheduler.SetSchedule(cleaner, "07:00", cleaner.RunMorningShift);
            Scheduler.SetSchedule(cleaner, "19:00", cleaner.RunEveningShift);

            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine("\n=== Smart Home System Menu ===");
                    Console.WriteLine("1. Turn ON a device");
                    Console.WriteLine("2. Turn OFF a device");
                    Console.WriteLine("3. Set Thermostat temperature");
                    Console.WriteLine("4. Unlock Door (Proxy)");
                    Console.WriteLine("5. Schedule HomeCleaner");
                    Console.WriteLine("6. Show Device Status");
                    Console.WriteLine("7. Run Scheduled Tasks");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            HandleTurnOn(hub);
                            break;

                        case "2":
                            HandleTurnOff(hub);
                            break;

                        case "3":
                            HandleThermostatTemp(hub);
                            break;

                        case "4":
                            HandleDoorUnlock(hub);
                            break;

                        case "5":
                            HandleScheduleCleaner(hub);
                            break;

                        case "6":
                            hub.ShowStatus();
                            break;

                        case "7":
                            HandleRunSchedule();
                            break;

                        case "0":
                            isRunning = false;
                            Console.WriteLine("Exiting Smart Home System. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Logger.Log($"Exception caught: {ex.Message}");
                }
            }
        }

        private static void HandleTurnOn(SmartHub hub)
        {
            Console.Write("Enter Device ID to Turn ON: ");
            int id = Validator.ValidateInt(Console.ReadLine());
            var device = hub.Devices.FirstOrDefault(d => d.Id == id);
            if (device != null)
            {
                device.TurnOn(); 
                Logger.Log($"{device.Name} {device.Id} turned ON");
            }
            else Console.WriteLine("Invalid Device ID");
        }

        private static void HandleTurnOff(SmartHub hub)
        {
            Console.Write("Enter Device ID to Turn OFF: ");
            int id = Validator.ValidateInt(Console.ReadLine());
            var device = hub.Devices.FirstOrDefault(d => d.Id == id);
            if (device != null)
            {
                device.TurnOff();
                Logger.Log($"{device.Name} {device.Id} turned OFF");
            }
            else Console.WriteLine("Invalid Device ID");
        }

        private static void HandleThermostatTemp(SmartHub hub)
        {
            Console.Write("Enter Thermostat ID: ");
            int id = Validator.ValidateInt(Console.ReadLine());
            Console.Write("Enter Temperature: ");
            int temp = Validator.ValidateInt(Console.ReadLine());

            var thermo = hub.Devices.FirstOrDefault(d => d.Id == id) as Thermostat;
            if (thermo != null)
            {
                thermo.SetTemperature(temp); 
                Logger.Log($"Thermostat {id} temperature set to {temp}");
            }
            else Console.WriteLine("Invalid Thermostat ID");
        }

        private static void HandleDoorUnlock(SmartHub hub)
        {
            Console.Write("Enter DoorLock ID: ");
            int id = Validator.ValidateInt(Console.ReadLine());
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            var doorProxy = hub.Devices.FirstOrDefault(d => d.Id == id) as DoorLockProxy;
            if (doorProxy != null)
            {
                doorProxy.Authorize(pin); 
                Logger.Log($"DoorLock {id} access attempted with PIN");
            }
            else Console.WriteLine("Invalid DoorLock ID");
        }

        private static void HandleScheduleCleaner(SmartHub hub)
        {
            Console.Write("Enter time to schedule HomeCleaner (HH:mm): ");
            string scheduleTime = Console.ReadLine();
            var cleaner = hub.Devices.FirstOrDefault(d => d is HomeCleaner) as HomeCleaner;

            if (Validator.ValidateTimeFormat(scheduleTime) && cleaner != null)
            {
                Scheduler.SetSchedule(cleaner, scheduleTime, cleaner.TurnOn);
                Console.WriteLine($"HomeCleaner scheduled at {scheduleTime}");
                Logger.Log($"HomeCleaner scheduled at {scheduleTime}");
            }
            else Console.WriteLine("Invalid input");
        }

        private static void HandleRunSchedule()
        {
            Console.Write("Enter current time (HH:mm) to run scheduled tasks: ");
            string currentTime = Console.ReadLine();
            Scheduler.RunSchedule(currentTime);
            Logger.Log($"Scheduled tasks run at {currentTime}");
        }
    }
}
