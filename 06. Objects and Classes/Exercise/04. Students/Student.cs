namespace _04._Students
{
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirtsName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirtsName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
