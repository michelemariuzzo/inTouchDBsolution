using System;
using System.Collections.Generic;

namespace inTouchDB //improve my knowledge on namespaces
{

	class Program //class is the definition of object
	{
		private const string loadMode = ":mode=replace";
		static Boolean InputIntegerControl(string inputValue)
		{
			int integerInputValue;
			bool success = int.TryParse(inputValue, out integerInputValue);
			if (integerInputValue > 0 && success)
				return true;
			else
				return false;
		}

		static Boolean InputIntegerControl2(string inputValue)
		{
			int integerInputValue;
			bool success = int.TryParse(inputValue, out integerInputValue);
			if (integerInputValue >= 0 && success)
				return true;
			else
				return false;
		}

		static Boolean ActuatorTypeControl(string inputValue)
		{
			char charInputValue;
			bool success = char.TryParse(inputValue, out charInputValue);
			if ((charInputValue == 'm' || charInputValue == 'v') && success)
				return true;
			else
				return false;
		}

		static Boolean ConfirmControl(string inputValue)
		{
			char charInputValue;
			bool success = char.TryParse(inputValue, out charInputValue);
			if (charInputValue == 'y' && success)
				return true;
			else
				return false;
		}

		static void Main(string[] args)
		{

			int from, to;
			//insert general info

			Console.WriteLine("Please enter an area char (MUST BE AN UPPER LETTER):");
			string area = Console.ReadLine();
			char areaChar = Convert.ToChar(area[0]);

			bool success = Char.IsLetter(areaChar) && Char.IsUpper(areaChar);
			while (!success)
			{
				Console.WriteLine("Invalid Input. Try again...");
				Console.WriteLine("Please enter an area char (MUST BE AN UPPER LETTER):");
				area = Console.ReadLine();
				areaChar = Convert.ToChar(area[0]);
				success = Char.IsLetter(areaChar) && Char.IsUpper(areaChar);
			}

			//create file
			string filePath = "C:\\Users\\Michele Mariuzzo\\Desktop\\" + Convert.ToString(areaChar) + "_LOAD.csv";
			System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath);
			file.WriteLine(loadMode);

			Console.WriteLine("Type access name:");
			string accessName = Console.ReadLine();

			//insert inputs

			Console.WriteLine("Would you insert INPUTS? [y/N]");
			string confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Console.WriteLine("Please enter how many INPUTS to add?");
				string inputNumber = Console.ReadLine();
				success = InputIntegerControl(inputNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many INPUTS to add?");
					inputNumber = Console.ReadLine();
					success = InputIntegerControl(inputNumber);
				}


				Console.WriteLine("Your INPUT start from?");
				string inputStartNumber = Console.ReadLine();
				success = InputIntegerControl2(inputStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your INPUT start from?");
					inputStartNumber = Console.ReadLine();
					success = InputIntegerControl2(inputStartNumber);
				}

				from = Int16.Parse(inputStartNumber);
				to = (from - 1) + Int16.Parse(inputNumber);


				Input inputObj = new Input();

				inputObj.AddInput(Convert.ToString(areaChar), accessName, from, to, file);
			}


			//insert actuators

			Console.WriteLine("Would you insert ACTUATORS? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Dictionary<int, string> actuator = new Dictionary<int, string>();

				Console.WriteLine("Please enter how many ACTUATORS to add?");
				string actNumber = Console.ReadLine();
				success = InputIntegerControl(actNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many ACTUATORS to add??");
					actNumber = Console.ReadLine();
					success = InputIntegerControl(actNumber);
				}

				Console.WriteLine("Your ACTUATORS start from?");
				string actStartNumber = Console.ReadLine();
				success = InputIntegerControl(actStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your ACTUATORS start from?");
					actStartNumber = Console.ReadLine();
					success = InputIntegerControl(actStartNumber);
				}

				from = Int16.Parse(actStartNumber);
				to = (from - 1) + Int16.Parse(actNumber);

				for (int i = from; i <= to; i++)
				{
					Console.WriteLine("Is a VALVE [v] or a MOTOR [m] the actuator n°" + i);
					string actType = Console.ReadLine();
					success = ActuatorTypeControl(actType);
					while (!success)
					{
						Console.WriteLine("Invalid Input. Try again...");
						Console.WriteLine("Is a VALVE [v] or a MOTOR [m] the actuator n°" + i);
						actType = Console.ReadLine();
						success = ActuatorTypeControl(actType);
					}
					actuator.Add(i, actType);
				}

				Actuator actuatorObj = new Actuator();
				actuatorObj.AddActuator(Convert.ToString(areaChar), accessName, actuator, file);
			}

			//insert analogs
			Console.WriteLine("Would you insert ANALOGS? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Console.WriteLine("Please enter how many ANALOG to add?");
				string analogNumber = Console.ReadLine();
				success = InputIntegerControl(analogNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many ANALOG to add?");
					analogNumber = Console.ReadLine();
					success = InputIntegerControl(analogNumber);
				}


				Console.WriteLine("Your ANALOG start from?");
				string analogStartNumber = Console.ReadLine();
				success = InputIntegerControl2(analogStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your ANALOG start from?");
					analogStartNumber = Console.ReadLine();
					success = InputIntegerControl2(analogStartNumber);
				}

				from = Int16.Parse(analogStartNumber);
				to = (from - 1) + Int16.Parse(analogNumber);


				Analog analogObj = new Analog();

				analogObj.AddAnalog(Convert.ToString(areaChar), accessName, from, to, file);
			}

			//insert alarms
			Console.WriteLine("Would you insert ALARMS? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Console.WriteLine("Please enter how many alarm to add?");
				string alarmNumber = Console.ReadLine();
				success = InputIntegerControl(alarmNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many alarm to add?");
					alarmNumber = Console.ReadLine();
					success = InputIntegerControl(alarmNumber);
				}


				Console.WriteLine("Your alarm start from?");
				string alarmStartNumber = Console.ReadLine();
				success = InputIntegerControl2(alarmStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your alarm start from?");
					alarmStartNumber = Console.ReadLine();
					success = InputIntegerControl2(alarmStartNumber);
				}

				from = Int16.Parse(alarmStartNumber);
				to = (from - 1) + Int16.Parse(alarmNumber);


				Alarm alarmObj = new Alarm();

				alarmObj.AddAlarm(Convert.ToString(areaChar), accessName, from, to, file);
			}


			//insert setups
			Console.WriteLine("Would you insert SETUPS? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Console.WriteLine("Please enter how many setup to add?");
				string setupNumber = Console.ReadLine();
				success = InputIntegerControl(setupNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many setup to add?");
					setupNumber = Console.ReadLine();
					success = InputIntegerControl(setupNumber);
				}


				Console.WriteLine("Your setup start from?");
				string setupStartNumber = Console.ReadLine();
				success = InputIntegerControl2(setupStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your setup start from?");
					setupStartNumber = Console.ReadLine();
					success = InputIntegerControl2(setupStartNumber);
				}

				from = Int16.Parse(setupStartNumber);
				to = (from - 1) + Int16.Parse(setupNumber);


				Setup setupObj = new Setup();

				setupObj.AddSetup(Convert.ToString(areaChar), accessName, from, to, file);
			}

			//insert PLC_SCADA tag
			Console.WriteLine("Would you insert SCADA Tags? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);


			if(success)
			{
				Console.WriteLine("Would you insert Boolean Tag? [y/N]");
				confirm = Console.ReadLine();
				success = ConfirmControl(confirm);
				if(success)
				{
					Console.WriteLine("Please enter your Boolean Ranges?");
					string booleanRanges = Console.ReadLine();
					PatternRange patternRangeBoolean = new PatternRange();
					List<Range> resultBoolean = new List<Range>();
					HmiTag booleanHmi = new HmiTag();
					success = patternRangeBoolean.getPatternRange(booleanRanges, out resultBoolean);
					
					while (!success)
					{
						booleanRanges = Console.ReadLine();
						success = patternRangeBoolean.getPatternRange(booleanRanges, out resultBoolean);
					}
					
					booleanHmi.AddHmiTag(area, accessName, "Ad", resultBoolean, file);			
					
				}

				Console.WriteLine("Would you insert Integer Tag? [y/N]");
				confirm = Console.ReadLine();
				success = ConfirmControl(confirm);
				if (success)
				{
					Console.WriteLine("Please enter your Integer Ranges?");
					string integerRanges = Console.ReadLine();
					PatternRange patternRangeInteger = new PatternRange();
					List<Range> resultInteger = new List<Range>();
					HmiTag integerHmi = new HmiTag();
					success = patternRangeInteger.getPatternRange(integerRanges, out resultInteger);

					while (!success)
					{
						integerRanges = Console.ReadLine();
						success = patternRangeInteger.getPatternRange(integerRanges, out resultInteger);
					}

					integerHmi.AddHmiTag(area, accessName, "Ad", resultInteger, file);
				}

				Console.WriteLine("Would you insert Real Tag? [y/N]");
				confirm = Console.ReadLine();
				success = ConfirmControl(confirm);
				if (success)
				{
					Console.WriteLine("Please enter your Real Ranges?");
					string realRanges = Console.ReadLine();
					PatternRange patternRangeReal = new PatternRange();
					List<Range> resultReal = new List<Range>();
					HmiTag realHmi = new HmiTag();
					success = patternRangeReal.getPatternRange(realRanges, out resultReal);

					while (!success)
					{
						realRanges = Console.ReadLine();
						success = patternRangeReal.getPatternRange(realRanges, out resultReal);
					}

					realHmi.AddHmiTag(area, accessName, "Ar", resultReal, file);
				}
			}

			//insert 82DataTrack
			Console.WriteLine("Would you insert DataTrack? [y/N]");
			confirm = Console.ReadLine();
			success = ConfirmControl(confirm);

			if (success)
			{
				Console.WriteLine("Please enter how many DataTrack to add?");
				string trackNumber = Console.ReadLine();
				success = InputIntegerControl(trackNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Please enter how many setup to add?");
					trackNumber = Console.ReadLine();
					success = InputIntegerControl(trackNumber);
				}


				Console.WriteLine("Your DataTrack start from?");
				string trackStartNumber = Console.ReadLine();
				success = InputIntegerControl2(trackStartNumber);
				while (!success)
				{
					Console.WriteLine("Invalid Input. Try again...");
					Console.WriteLine("Your DataTrack start from?");
					trackStartNumber = Console.ReadLine();
					success = InputIntegerControl2(trackStartNumber);
				}

				from = Int16.Parse(trackStartNumber);
				to = (from - 1) + Int16.Parse(trackNumber);


				TrackData82 trackData82Obj = new TrackData82();
			
				trackData82Obj.AddTrackData82(Convert.ToString(areaChar), accessName + "_AAI", from, to, file);
			}

			//close file
			file.Close();


		}
	}
	class Actuator
	{

		public void AddActuator(string area, string accessName, Dictionary<int, string> myDict, System.IO.StreamWriter CSVFile)
		{
			MemoryMsg recordMemoryMsg = new MemoryMsg();
			MemoryInt recordMemoryInt = new MemoryInt();
			IOInt recordIOInt = new IOInt();
			IOReal recordIOReal = new IOReal();
			IODisc recordIODisc = new IODisc();

			char doubleQuote = '"';

			// add tags of MemoryMsg type
			CSVFile.WriteLine(recordMemoryMsg.CSVTitleSerialize());
			foreach (KeyValuePair<int, string> entry in myDict)
			{
				//M     X_M_id#	            MemoryMsg
				//M     X_M_descr#          MemoryMsg
				recordMemoryMsg.SetMemoryMsg(area + "_M_id" + entry.Key);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

				recordMemoryMsg.SetMemoryMsg(area + "_M_descr" + entry.Key);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());
			}

			for (int i = 0; i <= 15; i++)
			{
				//M     X_Mlock_descr#	    MemoryMsg           0-15s
				recordMemoryMsg.SetMemoryMsg(area + "_Mlock_descr" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

			}

		
			//M     X_Mnote             MemoryMsg           1
			recordMemoryMsg.SetMemoryMsg(area + "_Mnote");
			CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

			// add tags of MemoryInt type
			CSVFile.WriteLine(recordMemoryInt.CSVTitleSerialize());
			foreach (KeyValuePair<int, string> entry in myDict)
			{
				//M     X_M_idx#            MemoryInt
				recordMemoryInt.SetMemoryInt(area + "_M_idx" + entry.Key);
				CSVFile.WriteLine(recordMemoryInt.CSVSerialize());
			}
			
			for (int i = 0; i <= 15; i++)
			{
				//M		X_Mcmd_#	MemoryInt
				recordMemoryInt.SetMemoryInt(area + "_Mcmd_" + i);
				CSVFile.WriteLine(recordMemoryInt.CSVSerialize());

				//M		X_Msts_#	MemoryInt
				recordMemoryInt.SetMemoryInt(area + "_Msts_" + i);
				CSVFile.WriteLine(recordMemoryInt.CSVSerialize());
			}

			// add tags of IOInt type
			CSVFile.WriteLine(recordIOInt.CSVTitleSerialize());
			foreach (KeyValuePair<int, string> entry in myDict)
			{
				recordIOInt.SetAccessName(accessName);

				//M     X_M_W#	            IOInt		DB30,B		(#-1)
				//M     X_M_R#	            IOInt		DB31,B		(#-1)
				//M     X_Mi_R#	            IOInt		DB32,INT		(#-1)*2

				recordIOInt.SetIOInt(area + "_M_W" + entry.Key);
				recordIOInt.SetItemName(doubleQuote + "DB30,B" + (entry.Key - 1) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_M_R" + entry.Key);
				recordIOInt.SetItemName(doubleQuote + "DB31,B" + (entry.Key - 1) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_Mi_R" + entry.Key);
				recordIOInt.SetItemName(doubleQuote + "DB32,INT" + ((entry.Key - 1) * 2) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				//M     X_Mp_W#_1       IOInt		DB33,D		(#-1)*16+0
				//M     X_Mp_W#_2	    IOInt		DB33,D		(#-1)*16+4
				//M     X_Mp_W#_3	    IOInt		DB33,D		(#-1)*16+8
				//M     X_Mp_W#_4	    IOInt		DB33,D		(#-1)*16+12

				recordIOInt.SetIOInt(area + "_Mp_W" + entry.Key + "_1");
				recordIOInt.SetItemName(doubleQuote + "DB33,D" + ((entry.Key - 1) * 16) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_Mp_W" + entry.Key + "_2");
				recordIOInt.SetItemName(doubleQuote + "DB33,D" + ((entry.Key - 1) * 16 + 4) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_Mp_W" + entry.Key + "_3");
				recordIOInt.SetItemName(doubleQuote + "DB33,D" + ((entry.Key - 1) * 16 + 8) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_Mp_W" + entry.Key + "_4");
				recordIOInt.SetItemName(doubleQuote + "DB33,D" + ((entry.Key - 1) * 16 + 12) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				//M     X_Mext_W#	    IOInt		DB35,W		(#-1)*2

				recordIOInt.SetIOInt(area + "_Mext_W" + entry.Key);
				recordIOInt.SetItemName(doubleQuote + "DB35,D" + ((entry.Key - 1) * 2) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				//M     X_Mcod_R#_1	    IOInt		DB2000,W	(#-1)*2+0		
				//M     X_Mcod_R#_2	    IOInt		DB2000,W	(#-1)*2+2

				recordIOInt.SetIOInt(area + "_Mcod_R" + entry.Key + "_1");
				recordIOInt.SetItemName(doubleQuote + "DB2000,W" + ((entry.Key - 1) * 4) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());

				recordIOInt.SetIOInt(area + "_Mcod_R" + entry.Key + "_2");
				recordIOInt.SetItemName(doubleQuote + "DB2000,W" + ((entry.Key - 1) * 4 + 2) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());


			}
			//M     X_Minv_W#_1	    IOReal		DB34,REAL	(#-1)*24+0
			//M     X_Minv_W#_2	    IOReal		DB34,REAL	(#-1)*24+4
			//M     X_Minv_W#_3	    IOReal		DB34,REAL	(#-1)*24+8
			//M     X_Minv_W#_4	    IOReal		DB34,REAL	(#-1)*24+12
			//M     X_Minv_W#_5	    IOReal		DB34,REAL	(#-1)*24+16
			//M     X_Minv_W#_6	    IOReal		DB34,REAL	(#-1)*24+20
			CSVFile.WriteLine(recordIOReal.CSVTitleSerialize());
			recordIOReal.SetAccessName(accessName);
			foreach (KeyValuePair<int, string> entry in myDict)
			{
				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_1");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_2");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24 + 4) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_3");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24 + 8) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_4");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24 + 12) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_5");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24 + 16) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_Minv_W" + entry.Key + "_6");
				recordIOReal.SetItemName(doubleQuote + "DB34,REAL" + ((entry.Key - 1) * 24 + 20) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());
			}

			//M     X_M_IFF#	    IODisc		DB31,X		#.05			X_Motor/X_Valve
			//M     X_M_ISV#	    IODisc		DB31,X		#.06			X_Motor/X_Valve
			//M     X_M_IFA#	    IODisc		DB31,X		#.07			X_Motor/X_Valve

			CSVFile.WriteLine(recordIODisc.CSVTitleSerialize());
			recordIODisc.SetAccessName(accessName);
			recordIODisc.SetAlarmState("On");

			foreach (KeyValuePair<int, string> entry in myDict)
			{
				if (entry.Value == "v")
					recordIODisc.SetGroup(area + "_Valve");
				else if (entry.Value == "m")
					recordIODisc.SetGroup(area + "_Motor");

				recordIODisc.SetIODisc(area + "_M_IFF" + entry.Key);
				recordIODisc.SetItemName(doubleQuote + "DB31,X" + (entry.Key - 1) + ".05" + doubleQuote);
				CSVFile.WriteLine(recordIODisc.CSVSerialize());

				recordIODisc.SetIODisc(area + "_M_ISV" + entry.Key);
				recordIODisc.SetItemName(doubleQuote + "DB31,X" + (entry.Key - 1) + ".06" + doubleQuote);
				CSVFile.WriteLine(recordIODisc.CSVSerialize());

				recordIODisc.SetIODisc(area + "_M_IFA" + entry.Key);
				recordIODisc.SetItemName(doubleQuote + "DB31,X" + (entry.Key - 1) + ".07" + doubleQuote);
				CSVFile.WriteLine(recordIODisc.CSVSerialize());
			}
			CSVFile.Flush();
		}
	}

	class Input
	{

		//class that add record tag for input
		#region resources for add an input
		//S     X_S_id#		MemoryMsg
		//S     X_S_descr#	MemoryMsg
		//S     X_S_R#		IODisc		DB59,X		X(#/8),(#MOD8)
		#endregion

		public void AddInput(string area, string accessName, int from, int to, System.IO.StreamWriter CSVFile)
		{

			MemoryMsg recordMemoryMsg = new MemoryMsg();
			IODisc recordIODisc = new IODisc();
			MemoryInt recordMemoryInt = new MemoryInt();

			// add tags of MemoryMsg type
			CSVFile.WriteLine(recordMemoryMsg.CSVTitleSerialize());

			for (int i = from; i <= to; i++)
			{
				//X_S_id# MemoryMessage
				recordMemoryMsg.SetMemoryMsg(area + "_S_id" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

				//X_S_descr# MemoryMessage
				recordMemoryMsg.SetMemoryMsg(area + "_S_descr" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());
			}

			// add tags of MemoryInt type
			CSVFile.WriteLine(recordMemoryInt.CSVTitleSerialize());
			for (int i = from; i<= to; i++)
			{
				recordMemoryInt.SetMemoryInt(area + "_S_idx" + i);
				CSVFile.WriteLine(recordMemoryInt.CSVSerialize());
			}


			// add tags of IODisc type
			CSVFile.WriteLine(recordIODisc.CSVTitleSerialize());

			for (int i = from; i <= to; i++)
			{
				recordIODisc.SetIODisc(area + "_S_R" + i);
				recordIODisc.SetAccessName(accessName);
				recordIODisc.SetItemName('"' + "DB59,X" + (i / 8) + ".0" + (i % 8) + '"');
				CSVFile.WriteLine(recordIODisc.CSVSerialize());
			}
			CSVFile.Flush();

		}
	}

	class Analog
	{

		//ANL X_ANL_PV#DB	    MemoryReal
		//ANL X_ANL_PV#HH	    MemoryReal
		//ANL X_ANL_PV#H	    MemoryReal
		//ANL X_ANL_PV#L	    MemoryReal
		//ANL X_ANL_PV#LL	    MemoryReal
		//ANL X_ANL_PV#KI	    MemoryReal
		//ANL X_ANL_PV#KD	    MemoryReal
		//ANL X_ANL_PV#KP       MemoryReal
		//ANL X_ANL_PV#MAX		MemoryReal
		//ANL X_ANL_PV#MIN		MemoryReal
		//ANL X_ANL_PV#TYPE		MemoryReal
		public void AddAnalog(string area, string accessName, int from, int to, System.IO.StreamWriter CSVFile)
		{
			MemoryMsg recordMemoryMsg = new MemoryMsg();
			MemoryInt recordMemoryInt = new MemoryInt();
			MemoryReal recordMemoryReal = new MemoryReal();
			IOReal recordIOReal = new IOReal();


			char doubleQuote = '"';

			// add tags of MemoryMsg type
			CSVFile.WriteLine(recordMemoryMsg.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//ANL X_ANL_id#			MemoryMsg
				//ANL X_ANL_descr#		MemoryMsg	
				//ANL X_ANL_unit#	    MemoryMsg

				recordMemoryMsg.SetMemoryMsg(area + "_ANL_id" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

				recordMemoryMsg.SetMemoryMsg(area + "_ANL_descr" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

				recordMemoryMsg.SetMemoryMsg(area + "_ANL_unit" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());

				//TREND X_Tpentag#	MemoryMessage
				recordMemoryMsg.SetMemoryMsg(area + "_Tpentag" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());
			}
		
			// add tags of MemoryInt type
			CSVFile.WriteLine(recordMemoryInt.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//ANL X_ANL_idx#	    MemoryInt
				recordMemoryInt.SetMemoryInt(area + "_ANL_idx" + i);
				CSVFile.WriteLine(recordMemoryInt.CSVSerialize());
			}

			// add tags of IOReal type

			//ANL X_ANL_PV#			IOReal		DB20,REAL	(#-1)*26+0		X_Analog
			//ANL X_ANL_HH#			IOReal		DB20,REAL	(#-1)*26+4
			//ANL X_ANL_H#			IOReal		DB20,REAL	(#-1)*26+8
			//ANL X_ANL_L#			IOReal		DB20,REAL	(#-1)*26+12
			//ANL X_ANL_LL#			IOReal		DB20,REAL	(#-1)*26+16
			//ANL X_ANL_DB#			IOReal		DB20,REAL	(#-1)*26+20
			CSVFile.WriteLine(recordIOReal.CSVTitleSerialize());
			recordIOReal.SetAccessName(accessName);

			for (int i = from; i <= to; i++)
			{
				recordIOReal.SetLoLoAlarmState("Yes");
				recordIOReal.SetLoAlarmState("Yes");
				recordIOReal.SetHiAlarmState("Yes");
				recordIOReal.SetHiHiAlarmState("Yes");

				recordIOReal.SetLoLoAlarmValue("-32768");
				recordIOReal.SetLoAlarmValue("-32767");
				recordIOReal.SetHiAlarmValue("32766");
				recordIOReal.SetHiHiAlarmValue("32767");

				recordIOReal.SetGroup(area + "_Analog");
				recordIOReal.SetIOReal(area + "_ANL_PV" + i);
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26) + doubleQuote);
				recordIOReal.SetLogged("Yes");
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetLoLoAlarmState("No");
				recordIOReal.SetLoAlarmState("No");
				recordIOReal.SetHiAlarmState("No");
				recordIOReal.SetHiHiAlarmState("No");

				recordIOReal.SetGroup("$System");

				recordIOReal.SetLogged("No");

				recordIOReal.SetIOReal(area + "_ANL_PV" + i + "HH");
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26 + 4) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_ANL_PV" + i + "H");
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26 + 8) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_ANL_PV" + i + "L");
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26 + 12) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_ANL_PV" + i + "LL");
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26 + 16) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				recordIOReal.SetIOReal(area + "_ANL_PV" + i + "DB");
				recordIOReal.SetItemName(doubleQuote + "DB20,REAL" + ((i - 1) * 26 + 20) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());
			}

			//ANL X_RIC_PV#DB	    MemoryReal
			//ANL X_RIC_PV#HH	    MemoryReal
			//ANL X_RIC_PV#H	    MemoryReal
			//ANL X_RIC_PV#L	    MemoryReal
			//ANL X_RIC_PV#LL	    MemoryReal
			//ANL X_RIC_PV#KI	    MemoryReal
			//ANL X_RIC_PV#KD	    MemoryReal
			//ANL X_RIC_PV#KP       MemoryReal
			//ANL X_RIC_PV#MAX		MemoryReal
			//ANL X_RIC_PV#MIN		MemoryReal
			//ANL X_RIC_PV#TYPE		MemoryReal

			CSVFile.WriteLine(recordMemoryReal.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "DB");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "HH");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "H");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "L");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "LL");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "KI");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "KD");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "KP");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "MAX");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "MIN");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());

				recordMemoryReal.SetMemoryReal(area + "_RIC_PV" + i + "TYPE");
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());


			}
			CSVFile.Flush();
		}

	}


	class Alarm
	{
		public void AddAlarm(string area, string accessName, int from, int to, System.IO.StreamWriter CSVFile)
		{
			MemoryMsg recordMemoryMsg = new MemoryMsg();
			IODisc recordIODisc = new IODisc();

			char doubleQuote = '"';

			// add tags of MemoryMsg type
			CSVFile.WriteLine(recordMemoryMsg.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//AL X_AL_descr#	MemoryMsg
				recordMemoryMsg.SetMemoryMsg(area + "_AL_descr" + i);
				CSVFile.WriteLine(recordMemoryMsg.CSVSerialize());
			}
			// add tags of MemoryMsg type
			CSVFile.WriteLine(recordIODisc.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//AL X_AL_R#		IODisc		DB500,X	        X(#/8),(#MOD8)		X_Alarm
				recordIODisc.SetIODisc(area + "_AL_R" + i);
				recordIODisc.SetAccessName(accessName);
				recordIODisc.SetGroup(area + "_Allarmi");
				recordIODisc.SetAlarmState("On");
				recordIODisc.SetItemName(doubleQuote + "DB500,X" + (i / 8) + ".0" + (i % 8) + doubleQuote);
				CSVFile.WriteLine(recordIODisc.CSVSerialize());
			}
			CSVFile.Flush();

		}
	}

	class Setup
	{


		public void AddSetup(string area, string accessName, int from, int to, System.IO.StreamWriter CSVFile)
		{
			MemoryReal recordMemoryReal = new MemoryReal();
			IOReal recordIOReal = new IOReal();

			char doubleQuote = '"';

			// add tags of MemoryReal type
			CSVFile.WriteLine(recordMemoryReal.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//STP X_Ric_Stp_W#	MemoryReal
				recordMemoryReal.SetMemoryReal(area + "_Ric_Stp_W" + i);
				CSVFile.WriteLine(recordMemoryReal.CSVSerialize());
			}
			// add tags of IOReal type
			CSVFile.WriteLine(recordIOReal.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				//STP X_Stp_W#	IOReal		DB6001,REAL	(#-1)*4

				recordIOReal.SetIOReal(area + "_Stp_W" + i);
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB6001,REAL" + ((i - 1)) * 4 +doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());
			}
			for (int i = from; i <= to; i++)
			{

				//STP X_Vis_Stp_R#	IOReal		DB61,REAL	(#-1)*4
				recordIOReal.SetIOReal(area + "_Vis_Stp_R" + i);
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB61,REAL" + ((i - 1) * 4) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());
			}
			CSVFile.Flush();

		}
	}

	class HmiTag
	{
		public void AddHmiTag(string area, string accessName, string typeName, List<Range> ranges, System.IO.StreamWriter CSVFile)
		{
			IOReal recordIOReal = new IOReal();
			IOInt recordIOInt = new IOInt();
			IODisc recordIODisc = new IODisc();
			char doubleQuote = '"';
			int i;
			int mod;
			int div;
			
			//insert X_Ad_W#
			if (typeName == "Ad")
			{
				CSVFile.WriteLine(recordIODisc.CSVTitleSerialize());
				foreach (Range r in ranges)
				{
					i = r.lowerExtreme;
					while (i <= r.upperExtreme)
					{
						mod = i % 10;
						div = i / 10;
						if (mod == 9 || mod == 8)
						{
							i++;
						}
						else
						{
							recordIODisc.SetIODisc(area + "_Ad_W" + div + mod);
							recordIODisc.SetAccessName(accessName);
							recordIODisc.SetItemName(doubleQuote + "DB40,X" + div + "." + mod + doubleQuote);
							CSVFile.WriteLine(recordIODisc.CSVSerialize());

							i++;
						}

					}

				}
				
			}

			//insert X_Ar_W#
			if (typeName == "Ar")
			{
				foreach (Range r in ranges)
				{
					CSVFile.WriteLine(recordIOReal.CSVTitleSerialize());
					for (i = r.lowerExtreme; i <= r.upperExtreme; i = i + 4)
					{
						recordIOReal.SetIOReal(area + "_Ar_W" + i);
						recordIOReal.SetAccessName(accessName);
						recordIOReal.SetItemName(doubleQuote + "DB40,REAL" + i + doubleQuote);
						CSVFile.WriteLine(recordIOReal.CSVSerialize());
					}
				}	
			}
			//insert X_Aa_W#
			if (typeName == "Aa")
			{
				foreach (Range r in ranges)
				{
					CSVFile.WriteLine(recordIOInt.CSVTitleSerialize());
					for (i = r.lowerExtreme; i <= r.upperExtreme; i = i + 2)
					{
						recordIOInt.SetIOInt(area + "_Aa_W" + i);
						recordIOInt.SetAccessName(accessName);
						recordIOInt.SetItemName(doubleQuote + "DB40,INT" + i + doubleQuote);
						CSVFile.WriteLine(recordIOInt.CSVSerialize());
					}
				}
			}

			CSVFile.Flush();
		}
		
		
	}

	class TrackData82
	{


		public void AddTrackData82(string area, string accessName, int from, int to, System.IO.StreamWriter CSVFile)
		{
			IOInt recordIOInt = new IOInt();
			IOReal recordIOReal = new IOReal();

			char doubleQuote = '"';

			// add tags of IOInt type
			CSVFile.WriteLine(recordIOInt.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{
				// X_Track_#_0				
				recordIOInt.SetIOInt(area + "_Track_" + i + "_0");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,DINT" + ((i - 1) * 38) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_4	
				recordIOInt.SetIOInt(area + "_Track_" + i + "_4");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,DINT" + ((i - 1) * 38 + 4) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_8				
				recordIOInt.SetIOInt(area + "_Track_" + i + "_8");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,INT" + ((i - 1) * 38 + 8) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_10	
				recordIOInt.SetIOInt(area + "_Track_" + i + "_10");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,INT" + ((i - 1) * 38 + 10) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_12	
				recordIOInt.SetIOInt(area + "_Track_" + i + "_12");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,INT" + ((i - 1) * 38 + 12) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_14
				recordIOInt.SetIOInt(area + "_Track_" + i + "_14");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,INT" + ((i - 1) * 38 + 14) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_16	
				recordIOInt.SetIOInt(area + "_Track_" + i + "_16");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,INT" + ((i - 1) * 38 + 16) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
				// X_Track_#_34	
				recordIOInt.SetIOInt(area + "_Track_" + i + "_34");
				recordIOInt.SetAccessName(accessName);
				recordIOInt.SetItemName(doubleQuote + "DB601,DINT" + ((i - 1) * 38 + 34) + doubleQuote);
				CSVFile.WriteLine(recordIOInt.CSVSerialize());
			}
			// add tags of IOReal type
			CSVFile.WriteLine(recordIOReal.CSVTitleSerialize());
			for (int i = from; i <= to; i++)
			{

				// X_Track_#_18	
				recordIOReal.SetIOReal(area + "_Track_" + i + "_18");
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB601,REAL" + ((i - 1) * 38 + 18) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				// X_Track_#_22	
				recordIOReal.SetIOReal(area + "_Track_" + i + "_22");
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB601,REAL" + ((i - 1) * 38 + 22) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				// X_Track_#_26
				recordIOReal.SetIOReal(area + "_Track_" + i + "_26");
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB601,REAL" + ((i - 1) * 38 + 26) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());

				// X_Track_#_30
				recordIOReal.SetIOReal(area + "_Track_" + i + "_30");
				recordIOReal.SetAccessName(accessName);
				recordIOReal.SetItemName(doubleQuote + "DB601,REAL" + ((i - 1) * 38 + 30) + doubleQuote);
				CSVFile.WriteLine(recordIOReal.CSVSerialize());
			}
			CSVFile.Flush();

		}
	}



}