using T1DConsole.Classes;

float carbRatioVal = 22;
float TargetBloodSugarVal = 120;
float CorrectionFactorVal = 80;

Console.WriteLine("Enter Carbs:");

Calculations calcObj = new Calculations();

// Carbs to be entered;
calcObj.Carb = float.Parse(Console.ReadLine()); 
calcObj.CarbRatio = carbRatioVal;
Console.WriteLine("----------------------");
Console.WriteLine($"Carb calculation: {calcObj.CalculateCarbs(calcObj.Carb, calcObj.CarbRatio).ToString("n2")}");
Console.WriteLine("----------------------");

Console.WriteLine("Enter Blood Sugar:");

// Blood sugar reading to be entered
calcObj.BloodSugar = float.Parse(Console.ReadLine());
calcObj.TargetBloodSugar = TargetBloodSugarVal;
calcObj.CorrectionFactor = CorrectionFactorVal;
Console.WriteLine("----------------------");
Console.WriteLine($"Blood Sugar: {calcObj.CalculateBloodSugar(calcObj.BloodSugar, calcObj.TargetBloodSugar, calcObj.CorrectionFactor).ToString("n2")}");
Console.WriteLine("----------------------");

// Total units of insulin
Console.WriteLine("**********************");
Console.WriteLine($"Total Units: {(calcObj.CalculateCarbs(calcObj.Carb, calcObj.CarbRatio) + calcObj.CalculateBloodSugar(calcObj.BloodSugar, calcObj.TargetBloodSugar, calcObj.CorrectionFactor)).ToString("n2")}");
Console.WriteLine("**********************");

