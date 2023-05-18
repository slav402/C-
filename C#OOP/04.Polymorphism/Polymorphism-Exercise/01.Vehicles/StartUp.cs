using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.Factotiess;
using Vehicles.Factotiess.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
//IWriter writer = new FileWriter(); // tova triabva da se podmeni s gornoto za da pishem vav file
IVehicleFactory vehicleFactory = new VehicleFactory();

IEngine engine = new Engine(reader, writer, vehicleFactory);

engine.Run();