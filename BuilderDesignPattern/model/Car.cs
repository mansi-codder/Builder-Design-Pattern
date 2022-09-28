using System;

namespace BuilderDesignPattern.model
{
    public partial class Car
    {

        private int id;
        private int height;
        private String brand;
        private String model;
        private String color;
        private String engine;
        private int nbrOfDoors;

       public Car(int id, String brand, String model, String color, int height, String engine, int nbrOfDoors)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.height = height;
            this.engine = engine;
            this.nbrOfDoors = nbrOfDoors;
        }
    }
}
