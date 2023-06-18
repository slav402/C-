using Raiding.IO;
using Raiding.IO.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.Engine.Interfaces;
using Raiding.Engine;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IBaseHeroFactories heroFactories = new HeroFactory();

IEngine engine = new Engine(reader, writer, heroFactories);

engine.Run();