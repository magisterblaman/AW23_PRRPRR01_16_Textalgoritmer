using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_16_Textalgoritmer {
	internal class Program {

		static int GetNumberInAlphabet(char input) {
			return char.ToUpper(input) - 'A' + 1;
		}

		static void Main(string[] args) {

			//string myText = "  Hej jag heter Hannes tjena tjena     ";

			//string trimmed = myText.Trim();
			//Console.WriteLine("|" + trimmed + "|");

			//string uppercase = myText.ToUpper();
			//string lowercase = myText.ToLower();

			//if (myText.Length > 35) {
			//	string extracted = myText.Substring(25, 10);

			//	Console.WriteLine(extracted);
			//}

			//string text2 = "Hello";
			//char[] text2AsCharArray = new char[] { 'H', 'e', 'l', 'l', 'o' };

			//char[] converted = text2.ToCharArray();
			//converted[2] = 'n';
			//string convertedBack = new string(converted);

			//for (int i = 0; i < convertedBack.Length; i++) {
			//	Console.Write(convertedBack[i]);
			//}

			//Console.WriteLine((char)('L' + 5));

			Console.WriteLine(GetNumberInAlphabet('å'));

		}
	}
}
