using System;

namespace BuilderDesignPattern.model
{
    public class CarSchema
    {

        private int id;
        private int height;
        private String brand;
        private String model;
        private String color;
        private String engine;
        private int nbrOfDoors;

      public  CarSchema(int id, String brand, String model, String color, int height, String engine, int nbrOfDoors)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.height = height;
            this.engine = engine;
            this.nbrOfDoors = nbrOfDoors;
        }


        //public String toString()
        //{
        //    return """
        //            CarSchema {
        //        id =% s,
        //            height =% s,
        //            brand =% s,
        //            model =% s,
        //            color =% s,
        //            engine =% s,
        //            nbrOfDoors =% s
        //        }
        //    """.formatted(id, height, brand, model, color, engine, nbrOfDoors);
        //}

    }
}
