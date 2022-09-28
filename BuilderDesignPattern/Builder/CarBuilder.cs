using System;

namespace BuilderDesignPattern.model
{
    public class CarBuilder : IBuilder
    {

        private int _id;
        private int _height;
        private String _brand;
        private String _model;
        private String _color;
        private String _engine;
        private int _nbrOfDoors;


        public IBuilder id(int id)
        {
            _id = id;
            return this;
        }


        public IBuilder brand(String brand)
        {
            _brand = brand;
            return this;
        }


        public IBuilder model(String model)
        {
            _model = model;
            return this;
        }


        public IBuilder color(String color)
        {
            _color = color;
            return this;
        }


        public IBuilder height(int height)
        {
            _height = height;
            return this;
        }


        public IBuilder engine(String engine)
        {
            _engine = engine;
            return this;
        }


        public IBuilder nbrOfDoors(int nbrOfDoors)
        {
            _nbrOfDoors = nbrOfDoors;
            return this;
        }

    public Car build()
    {
        return new Car(_id, _brand, _model, _color, _height, _engine, _nbrOfDoors);
    }
}
}
