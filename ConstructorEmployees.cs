Using System;
Using System.Linq;

namespace Employee

internal class Program
{
 
    
    private string employeeName;
    private DateTime dateOfBirth;
    private bool gender;
    private int employeeId;
    private static int nextEmployeeNumber = 1001;
    private string[] dependents = new string[3];
    private short numberOfDependents = 0;

   
    
    static Employee()
    {
        nextEmployeeNumber = 1001;
    }

    
    public Employee()
    {
        employeeId = nextEmployeeNumber++;
        dependents = new string[3];
    }

    
    
    public Employee(string name, DateTime dob, bool gender)
    {
        this.employeeName = name;
        this.dateOfBirth = dob;
        this.gender = gender;
        employeeId = nextEmployeeNumber++;
        dependents = new string[3];
    }

    
    
    public Employee(string name, DateTime dob, bool gender, short numberOfDependents)
        : this(name, dob, gender) // Calls the above constructor to initialize other member variables
    {
        if (numberOfDependents < 0)
            this.numberOfDependents = 0;
        else if (numberOfDependents > 3)
            this.numberOfDependents = 3;
        else
            this.numberOfDependents = numberOfDependents;
    }

    // Add a dependent 
    
    
    public short AddDependent(string dependentName)
    {
        if (numberOfDependents < 3)
        {
            dependents[numberOfDependents++] = dependentName;
            return numberOfDependents;
        }
        else
            return 0;
    }

    // Update the name of a dependent
    
    public bool UpdateDependents(string dependentName, int dependentId)
    {
        if (dependentId > 0 && dependentId <= numberOfDependents)
        {
            dependents[dependentId - 1] = dependentName;
            return true;
        }
        else
            return false;
    }
}