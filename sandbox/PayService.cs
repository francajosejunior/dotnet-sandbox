namespace sandbox;
public class PayService
{
    private IDeductionService deductionService = new MGDeductionService();
    public double tax(double amount)
    {
        amount = amount - deductionService.deduction(amount);
        return amount * 0.2;
    }
}
