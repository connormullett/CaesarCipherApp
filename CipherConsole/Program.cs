using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Run();
		}

		static void Run()
		{
			Console.Clear();
			Console.WriteLine("1. Encipher Text\n2. Decipher Text\n3. Exit");
			decimal input = decimal.Parse(Console.ReadLine());

			if(input == 1)
				UIEncipher();
			else if(input == 2)
				UIDecipher();
			else if(input == 3)
				UIExit();
			else
				Run();
		}

		static void UIEncipher()
		{
			Console.Clear();
			Console.WriteLine("Enter Text to Encrypt: ");
			string input = Console.ReadLine();

			Console.WriteLine("Enter a Key: ");
			int key = int.Parse(Console.ReadLine());

			Encipher(input, key);
			Console.Clear();
			Console.WriteLine("Encrypted String: " + Encipher(input, key));
			Console.ReadKey();
			Run();
		}

		static void UIDecipher()
		{
			Console.Clear();
			Console.WriteLine("Enter Text to Decrypt: ");
			string input = Console.ReadLine();
			Console.WriteLine("Enter the Key: ");
			int key = int.Parse(Console.ReadLine());

			Console.WriteLine(Decipher(input, key));
			Console.ReadKey();
			Run();
		}

		static void UIExit()
		{

		}

		static string Encipher(string input, int key)
		{
			string output = string.Empty;
				
			foreach (char ch in input)
			{
				output += Cipher(ch, key);
			}

			return output;
		}

		static char Cipher(char ch, int key)
		{
			if (!char.IsLetter(ch))
				return ch;

			char d = char.IsUpper(ch) ? 'A' : 'a';
			return (char)((((ch + key) - d) % 26) + d);
		
		}

		static string Decipher(string input, int key)
		{
			return Encipher(input, 26 - key);
		}
	}
}
