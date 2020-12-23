using System;
using System.Collections.Generic;
using System.Text;

namespace inTouchDB
{
	class PatternRange
	{
		public bool getPatternRange(string inputRange, out List<Range> rangeListOut)
		{
			int charCounter;
			bool status = false;
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
					{
						rangeList.Add(new Range { lowerExtreme = integerLowerExtreme, upperExtreme = integerLowerExtreme });
						status = true;
						
					}
					else
					{
						status = false;
						break;
					}
				
				}
				else
				{
					//parse the extremes
							
					extreme = word.Split('-');
					success = int.TryParse(extreme[0], out integerLowerExtreme) && int.TryParse(extreme[1], out integerUpperExtreme);
					if (success && (integerLowerExtreme <= integerUpperExtreme))
					{
						rangeList.Add(new Range { lowerExtreme = integerLowerExtreme, upperExtreme = integerUpperExtreme });
						status = true;
					}
					else
					{ 
						status = false;
						break;
					}

				}
			}
			if (status)
			{
				rangeListOut = rangeList;
				return true;
			}
			else
			{
				rangeListOut = rangeList;
				return false;
			}
			
			
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
