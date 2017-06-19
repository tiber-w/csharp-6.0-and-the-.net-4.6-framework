using System;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

        public Person()
        {
        }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public override string ToString()
        {
            return String.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
        }

        public override bool Equals(object obj)
        {
            //if ((obj is Person) && (obj != null))
            //{
            //    Person temp = (Person)obj;
            //    if (temp.FirstName == this.FirstName
            //        && temp.LastName == this.LastName
            //        && temp.Age == this.Age)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            // No need to cast "obj" to a Person anymore,
            // as everything has a ToString() method.
            return (obj.ToString() == this.ToString());
        }

        // Return a hash code based on a point of unique string data.
        //public override int GetHashCode()
        //{
        //    return SSN.GetHashCode();
        //}

        // Return a hash code based on the person's ToString() value.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
