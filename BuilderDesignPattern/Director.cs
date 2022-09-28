namespace BuilderDesignPattern
{

    public class Director
    {
        public void buildBugatti(model.IBuilder builder)
        {
            builder.brand("Bugatti")
                    .color("Blue")
                    .nbrOfDoors(2)
                    .engine("8L")
                    .height(115);
        }

        public void buildLambo(model.IBuilder builder)
        {
            builder.brand("Lamborghini")
                    .model("Aventador")
                    .color("Yellow")
                    .height(120);
        }
    }
}

