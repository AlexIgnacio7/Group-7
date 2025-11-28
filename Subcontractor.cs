using System;

public class Subcontractor : Contractor
{
    private int shift;
    private double hourlyPayRate;

    public Subcontractor()
    {
    }

    public Subcontractor(string name, int number, DateTime startDate,
                         int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        this.shift = shift;
        this.hourlyPayRate = hourlyPayRate;
    }

    public int Shift
    {
        get { return shift; }
        set { shift = value; }
    }

    public double HourlyPayRate
    {
        get { return hourlyPayRate; }
        set { hourlyPayRate = value; }
    }

    public float ComputePay(float hoursWorked)
    {
        double rate = hourlyPayRate;

        if (shift == 2)
        {
            rate *= 1.03;
        }

        return (float)(rate * hoursWorked);
    }
}
