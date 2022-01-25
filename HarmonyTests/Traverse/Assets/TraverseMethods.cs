using System.Linq;

namespace HarmonyLibTests.Assets
{
	public class TraverseMethods_Instance
	{
		public bool Method1_called;

		void Method1()
		{
			Method1_called = true;
		}

		string Method2(string arg1)
		{
			return arg1 + arg1;
		}
	}

	public static class TraverseMethods_Static
	{
		static int StaticMethod(int a, int b)
		{
			return a * b;
		}
	}

	public static class TraverseMethods_VarArgs
	{
		static int Test1(int a, int b)
		{
			return a + b;
		}

		static int Test2(int a, int b, int c)
		{
			return a + b + c;
		}
		static int Test3(int multiplier, params int[] n)
		{
			return n.Aggregate(0, (acc, x) => acc + x) * multiplier;
		}
	}

	public static class TraverseMethods_Parameter
	{
		static string WithRefParameter(ref string refParameter)
		{
			refParameter = "hello";
			return "ok";
		}

		static string WithOutParameter(out string refParameter)
		{
			refParameter = "hello";
			return "ok";
		}

		static T WithGenericParameter<T>(T refParameter)
		{
			return refParameter;
		}
	}

	public class TraverseMethods_Overloads
	{
		public bool SomeMethod(string p1, bool p2 = true)
		{
			return !p2;
		}

		public int SomeMethod(string p1, int p2, bool p3 = true)
		{
			return 0;
		}
	}
}
