namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myClass satyajeet = new myClass(17,"satyajeet" ,87);
            Console.WriteLine(satyajeet.ToString());
            Console.WriteLine(satyajeet.getAge());
            Console.WriteLine(satyajeet.getName());
            Console.WriteLine(satyajeet.getPercent());
            Console.WriteLine(satyajeet.GetType());
            //Console.WriteLine(satyajeet.);

        }

        class myClass
        {
            int age;
            string name;
            float percent;
            public myClass(int age, string name, float percent)
            {
                this.age = age;
                this.name = name;
                this.percent = percent;
            }
            public int getAge() { return age; }
            public string getName() { return name; }
            public float getPercent() { return percent; }

        }
    }
}
