using System;
using System.Collections.Generic;

namespace patternTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			List<Range> result = new List<Range>();
			PatternRange patternRangeObj = new PatternRange();
			Console.WriteLine("Hello World!");
			
			input = Console.ReadLine();

			result = patternRangeObj.getPatternRange(input);

			foreach (Range r in result)
				Console.WriteLine(r.ToString());
		}
	}

	class PatternRange
	{
		public List<Range> getPatternRange(string inputRange)
		{
			int charCounter;
			int integerLowerExtreme = 0;
			int integerUpperExtreme = 0;
			string[] ranges = inputRange.Split(' ');
			string[] extreme;
			bool success;
			List<Range> rangeList = new List<Range>();


			//There is a difference between "string" and "String" and i need to dig to improve my knowledge

			foreach (string word in ranges)
			{
				charCounter = 0;
				foreach (char c in word)
				{
					if(c.Equals('-'))
					{
						charCounter++;
					}
				}
				if (charCounter == 0)
				{
					
					success = int.TryParse(word, out integerLowerExtreme);
					if (success)
						rangeList.Add(new Range { lowerExtreme = integerLowerExtreme, upperExtreme = integerLowerExtreme });
					else
						//throw new System.ArgumentException("Parameter cannot be null", "original");
						throw new System.ArgumentException("Parameter is not a number", "original");

				}
				else
				{
					//parse the extremes
							
					extreme = word.Split('-');
					success = int.TryParse(extreme[0], out integerLowerExtreme) && int.TryParse(extreme[1], out integerUpperExtreme);
					if (success && (integerLowerExtreme <= integerUpperExtreme))
						rangeList.Add(new Range { lowerExtreme = integerLowerExtreme, upperExtreme = integerUpperExtreme });
					else
						//throw new System.ArgumentException("Parameter cannot be null", "original");
						throw new System.ArgumentException("Parameter is not a number", "original");

				}
			}
			
			return rangeList;
		}
	
	}

	class Range

	{
		public int lowerExtreme, upperExtreme;
		public Range()
		{
			lowerExtreme = 0;
			upperExtreme = 0;		
		}
		//Override ToString method
		public override string ToString()
		{
			return "[" + lowerExtreme + ", " + upperExtreme + "]";
		}
	}

	
}
