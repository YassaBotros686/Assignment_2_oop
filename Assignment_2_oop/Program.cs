namespace Assignment_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            #region Q1
            //people[0] = new Person("Alice", 25);
            //people[1] = new Person("Bob", 30);
            //people[2] = new Person("Charlie", 22);

            //Console.WriteLine("Details of Persons:");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //} 
            #endregion

            #region Q2
            //Console.WriteLine("Enter coordinates of first point:");
            //Console.Write("X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Point p1 = new Point(x1, y1);

            //Console.WriteLine("Enter coordinates of second point:");
            //Console.Write("X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Point p2 = new Point(x2, y2);

            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //Console.WriteLine($"\nDistance between the two points = {distance:F2}"); 
            #endregion

            #region Q3
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //    Console.WriteLine();
            //}

            //Person oldest = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}"); 
            #endregion

            #region Q4
            //Rectangle r = new Rectangle();
            //r.Width = 10;
            //r.Height = 5;
            //r.Width = -4;
            //r.DisplayInfo(); 
            #endregion

        }
    }
}
