﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_16_Textalgoritmer {
	internal class Program {

		static int GetNumberInAlphabet(char input) {
			return char.ToUpper(input) - 'A' + 1;
		}

		static string EncryptString(string input, int shift) {
			string output = "";
			for (int i = 0; i < input.Length; i++) {
				output += (char)(input[i] + shift);
			}
			return output;
		}

		static string DecryptString(string input, int shift) {
			return EncryptString(input, -shift);
		}

		static string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";

		static int FindPositionInAlphabet(char input) {
			input = char.ToLower(input);
			for (int i = 0; i < alphabet.Length; i++) {
				if (alphabet[i] == input) {
					return i;
				}
			}
			return -1;
		}

		static string BetterEncrypt(string input, int shift) {
			string output = "";
			for (int i = 0; i < input.Length; i++) {
				int inputLetterPos = FindPositionInAlphabet(input[i]);
				int newLetterPos = inputLetterPos + shift;
				int modulo = BetterModulus(newLetterPos, alphabet.Length);
				output += alphabet[modulo];
			}
			return output;
		}

		static string BetterDecrypt(string input, int shift) {
			return BetterEncrypt(input, -shift);
		}

		static int BetterModulus(int num, int den) {
			return (num % den + den) % den;
		}

		static void Main(string[] args) {

			string myInput = "älgzoo123";
			string myOutput = BetterEncrypt(myInput, 5);
			//string decrypted = BetterDecrypt(myInput, 5);

			Console.WriteLine(myOutput);
			//Console.WriteLine(decrypted);

		}
	}
}
