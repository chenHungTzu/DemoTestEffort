namespace DemoTestEffort
{
    public class Counter
    {
        public Counter(int number, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero");
            }
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative");
            }

            this.Remainder = number % divisor;
        }

        public int Remainder { get; }

        public string TableName
        {
            get => this.Remainder switch
            {
                0 => "Table0",
                1 => "Table1",
                2 => "Table2",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}