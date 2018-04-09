namespace BecomingDev.Test
{
    public class Composition
    {
        public int Number { get; set; }
    }

    public class HereWeGo
    {
        private Composition _composition;

        public int Age { get; set; }


        public HereWeGo(Composition composition)
        {
            Age = composition.Number;
        }
    }
}