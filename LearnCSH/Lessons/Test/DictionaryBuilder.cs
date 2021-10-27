using System;
using System.Collections.Generic;

namespace Lessons.Test
{
    class DictionaryBuilder
    {
		public static Dictionary<int, int> BuildNumbersDictionary(int [] array)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (var number in array)
			{
				if (dictionary.ContainsKey(number))
				{
					dictionary[number] += 1;
				}
				else
				{
					dictionary.Add(number, 1);
				}
			}

			return dictionary;
		}

		public static Dictionary<string, int> BuildWordsDictionary(string text)
		{
			// 1. Проверяем входные параметры --------------------------------
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException("word can not be null!");
			}

			Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
			foreach (var word in text.Split(' '))
			{
				string formatedWord = PrepareWord(word);
				if (wordsDictionary.ContainsKey(formatedWord))
				{
					wordsDictionary[formatedWord] += 1;
				}
				else
				{
					wordsDictionary.Add(formatedWord, 1);
				}
			}

			return wordsDictionary;
		}

		private static string PrepareWord(string word)
		{
			// 1. Проверяем входные параметры --------------------------------
			if (string.IsNullOrEmpty(word))
			{
				throw new ArgumentNullException("word can not be null!");
			}

			// 2. Переводим слово в нижний регистр ---------------------------
			word = word.ToLower();

			// 3. Удаляем знаки пунктуации, если они есть --------------------
			if (word.EndsWith(",") || word.EndsWith("."))
			{
				word = word.Remove(word.Length - 1);
			}

			// 4. Убираем ковычки если они есть ------------------------------
			if (word.Contains("'"))
			{
				while (word.Contains("'"))
				{
					int indx = word.IndexOf("'");
					word = word.Remove(indx, 1);
				}
			}

			return word;
		}
	}
}
