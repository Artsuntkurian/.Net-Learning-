/*
    Hospital management System
*/







using System;
using System.Collections.Generic;

abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    protected string Department { get; set; }
    private string? Disease;
    

    public Person(int id, string name, string department, string? disease = null)
    {
        Id = id;
        Name = name;
        Department = department;
        Disease = disease;
    }
    
    public virtual string GetDetails()
    {
        return $"Id: {Id}, Name: {Name}, Department: {Department}";
    }
    
    public abstract void PerformDuty();
    
    protected string? GetDisease()
    {
        return Disease;
    }
}



class Doctor : Person
{
    public Doctor(int id, string name, string department) 
        : base(id, name, department) 
    {
    }
    
    public override void PerformDuty()
    {
        Console.WriteLine($"Doctor {Name} is treating patients.");
    }
}


class Nurse : Person
{
    public Nurse(int id, string name, string department) 
        : base(id, name, department)
    {
    }
    
    public override void PerformDuty()
    {
        Console.WriteLine($"Nurse {Name} is assisting doctors.");
    }
}




class Patient : Person
{
    public Patient(int id, string name, string disease) 
        : base(id, name, "N/A", disease) 
    {
    }
    
    public override string GetDetails()
    {
        return $"Id: {Id}, Name: {Name}, Disease: {GetDisease()}";
    }
    
    public override void PerformDuty()
    {
        Console.WriteLine($"Patient {Name} is receiving treatment.");
    }
}









class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        
        people.Add(new Doctor(1, "Krishna", "Cardiology"));
        people.Add(new Nurse(2, "Ravi", "ICU"));
        people.Add(new Patient(3, "Anu", "Fever"));
        
        
        foreach (Person p in people)
        {
            Console.WriteLine(p.GetDetails()); 
            Console.WriteLine();
        }
    }
}