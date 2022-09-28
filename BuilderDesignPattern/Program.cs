using BuilderDesignPattern.model;
using System;
using static BuilderDesignPattern.model.Car;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            CarBuilder builder = new CarBuilder();
            director.buildBugatti(builder);
            builder.model("Chiron");
            Console.WriteLine(builder.build());

            CarSchemaBuilder schemaBuilder = new CarSchemaBuilder();
            director.buildLambo(schemaBuilder);
            schemaBuilder.engine("90").nbrOfDoors(3);
            Console.WriteLine(schemaBuilder.build());
        }
    }
}
