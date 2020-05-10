namespace DogRace
{
    public static class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Jhon();
                case 1: return new Patlu();
                case 2: return new Moto();
                default: return null;
            }
        }

    }
}
