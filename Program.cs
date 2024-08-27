


using Parameter;
using System.Transactions;

class Program
{
	public static void Main()
	{
		// Simple And Input Parameter
		FunctionParameter functionParameter = new FunctionParameter();
		functionParameter.Addition(30, 20); 


		// Complex And Input Parameter
		FunctionParameter functionParameter1 = new FunctionParameter();
		functionParameter1.Num1 = 30;
		functionParameter1.Num2 = 20;
		
		FunctionParameter functionParameter2 = new FunctionParameter();
		functionParameter.Substratction(functionParameter1);

		// Output Parameter
		int Result;
		FunctionParameter functionParameter3 = new FunctionParameter();
		functionParameter3.Multiplication(5, 2, out Result);
		Console.WriteLine($"Multiplication = {Result}");

		// Input-Output Parameter 
		int Result1=11;
		FunctionParameter functionParameter4 = new FunctionParameter();
		functionParameter4.Division(10,5,ref Result1);
		Console.WriteLine($"Division = {Result1}");
	}
}