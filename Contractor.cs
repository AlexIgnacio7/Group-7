using System;

public class Contractor
{
    // Fields
    private string contractorName;
    private int contractorNumber;
    private DateTime contractorStartDate;

    // Constructors
    public Contractor()
    {
    }

    public Contractor(string name, int number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    // Accessors / Mutators (Properties)
    public string ContractorName
    {
        get { return contractorName; }
        set { contractorName = value; }
    }

    public int ContractorNumber
    {
        get { return contractorNumber; }
        set { contractorNumber = value; }
    }

    public DateTime ContractorStartDate
    {
        get { return contractorStartDate; }
        set { contractorStartDate = value; }
    }
}
