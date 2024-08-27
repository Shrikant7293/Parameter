using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
	internal class FunctionParameter
	{
		public int Num1 { get; set; }
		public int Num2 { get; set; }

		#region Simple And Input Parameter

		public void Addition(int A, int B)
		{
			int Result = A + B;

			Console.WriteLine($"Addition Of {A} & {B} = {Result}");
		}

		#endregion

		#region Complex And Input Parameter
		public void Substratction(FunctionParameter parameter)
		{
			int Result = parameter.Num1 - parameter.Num2;
			Console.WriteLine($"Substraction Of {parameter.Num1} & {parameter.Num2} = {Result}");
		}

		#endregion

		#region Output Parameter

		public void Multiplication(int a, int b, out int Result)
		{
			Result = a * b;
			Console.WriteLine($"Multiplication Of {a} & {b} = {Result}");
		}

		#endregion

		#region Input-Output Parameter

		public void Division(int x, int y, ref int Result1)
		{
			int Result = Result1 + x / y;
			Console.WriteLine($"Division Of {Result1} + {x} / {y}   = {Result}");
		}

		#endregion
	}
}
