using sandbox;

PayService payService = new PayService();
double tax = payService.tax(1000.0);
Console.WriteLine($"O valor da taxa é {tax}");