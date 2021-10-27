using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Test
{
	class ArrayToolDmitriy
	{
		public static int[] Most_Frequently_Used_Numbers(int[] array)
		{
			int[] result = new int[3];

			Dictionary<int, int> wordsDictionary = DictionaryBuilder.BuildNumbersDictionary(array);

			int max1 = 0;
			int max2 = 0;
			int max3 = 0;
			foreach (var item in wordsDictionary)
			{
				if (item.Value > max1)
				{
					max3 = max2;
					result[2] = result[1];

					max2 = max1;
					result[1] = result[0];

					max1 = item.Value;
					result[0] = item.Key;
				}
				else if (item.Value > max2)
				{
					max3 = max2;
					result[2] = result[1];

					max2 = item.Value;
					result[1] = item.Key;
				}
				else if (item.Value > max3)
				{
					max3 = item.Value;
					result[2] = item.Key;
				}
			}

			return result;
		}
	}
}
