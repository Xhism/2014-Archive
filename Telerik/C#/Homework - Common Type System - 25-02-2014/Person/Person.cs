using System;

public class Person
{
    //Fields
    private string name;
    private int? age;

    //Properties
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int? Age
    {
        get { return this.age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            this.age = value;
        }
    }

    //Constructor
    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    //Methods
    public override string ToString()
    {
        return string.Format("Name : {0}\nAge : {1}", this.Name,
            this.Age.ToString() == string.Empty ?  "Unknown age" : this.Age.ToString());
    }
}

