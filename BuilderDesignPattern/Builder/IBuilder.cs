using System;

namespace BuilderDesignPattern.model
{
    public interface IBuilder
    {
        IBuilder id(int id);

        IBuilder brand(String brand);

        IBuilder model(String model);

        IBuilder color(String color);

        IBuilder height(int height);

        IBuilder engine(String engine);

        IBuilder nbrOfDoors(int nbrOfDoors);

    }
}
