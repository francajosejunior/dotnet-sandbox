// See https://aka.ms/new-console-template for more information



namespace sandbox;

public class MGDeductionService : IDeductionService
{
    public double deduction(double amount)
    {
        return amount * 0.12;
    }
}
