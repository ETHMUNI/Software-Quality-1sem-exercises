namespace Ex04_Employees;

public class Employee
{
    private string cpr;
    private string firstName;
    private string lastName;
    private Department department;
    private decimal salary;
    private EducationalLevel educationalLevel;
    private DateTime dateOfBirth;
    private DateTime dateOfEmployment;
    private string country;
    
    public string getCpr()
    {
        return cpr;
    }
    public string setCpr(string newCpr)
    {
        return cpr = newCpr;
    }

    public string getFirstName()
    {
        return firstName;
    }
    public string setFirstName(string newFirstName)
    {
        return firstName = newFirstName;
    }

    public string getLastName()
    {
        return lastName;
    }
    public string setLastName(string newLastName)
    {
        return lastName = newLastName;
    }

    public Department getDepartment()
    {
        return department;
    }
    public Department setDepartment(Department newDepartment)
    {
        return department = newDepartment;
    }

    public decimal getSalary()
    {
        var actualSalary = salary + (int)educationalLevel * 1200;
        return actualSalary;
    }
    public decimal setSalary(decimal newSalary)
    {
        return salary = newSalary;
    }

    public EducationalLevel getEducationalLevel()
    {
        return educationalLevel;
    }
    public EducationalLevel setEducationalLevel(EducationalLevel newEducationalLevel)
    {
        return educationalLevel = newEducationalLevel;
    }

    public DateTime getDateOfBirth()
    {
        return dateOfBirth;
    }
    public DateTime setDateOfBirth(DateTime newDateOfBirth)
    {
        return dateOfBirth = newDateOfBirth;
    }

    public string getCountry()
    {
        return country;
    }

    public string setCountry(string newCountry)
    {
        return country = newCountry;
    }

    public string getDiscount()
    {
        var discount = (int)dateOfEmployment * 0.5
    }



}

public enum Department {
    HR,
    Finance,
    IT,
    Sales,
    GeneralServices
}

public enum EducationalLevel
{
    None = 0,
    Primary = 1,
    Secondary = 2,
    Tertiary = 3
}