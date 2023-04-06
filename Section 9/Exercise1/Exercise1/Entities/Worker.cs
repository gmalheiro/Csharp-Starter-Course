using Exercise1.Entities;
using Exercise1.Entities.Enums;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Department Department { get; set; }
    List<HourContract> Contracts = new List<HourContract>();

    public Worker()
    {

    }

    public Worker(string name, WorkerLevel level, double baseSalary, Department department)
    {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;
    }

    public void AddContract(HourContract contract)
    {
        Contracts.Add(contract);
    }

    public void removeContract(HourContract contract)
    {
        Contracts.Remove(contract);
    }
    
    public double Income(int year, int month )
    {
        double income = BaseSalary;
        foreach (HourContract contract  in Contracts)
        {
            if (contract.Date.Year == year && contract.Date.Month == month)
            {
                income += contract.TotalValue();
            }
        }
        return income;
    }

}
