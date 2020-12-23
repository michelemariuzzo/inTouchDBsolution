using System;
using System.Collections.Generic;
using System.Text;

namespace inTouchDB
{

    class MemoryDisc
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor
        public MemoryDisc()
        {
            
            tagRecord.Add("MemoryDisc", "defaultName");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("InitialDisc", "Off");
            tagRecord.Add("OffMsg", "");
            tagRecord.Add("OnMsg", "");
            tagRecord.Add("AlarmState", "None");
            tagRecord.Add("AlarmPri", "1");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "0");
            tagRecord.Add("DSCAlarmDisable", "0");
            tagRecord.Add("DSCAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");
        }

        //Methods
        public void SetMemoryDisc(string value)
        {
            tagRecord["MemoryDisc"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }
        public void SetAlarmState(string value)
        {
            tagRecord["AlarmState"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }

    class IODisc
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance
       

        public IODisc()
        {

            tagRecord.Add("IODisc", "defaultName");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("InitialDisc", "Off");
            tagRecord.Add("OffMsg", "");
            tagRecord.Add("OnMsg", "");
            tagRecord.Add("AlarmState", "None");
            tagRecord.Add("AlarmPri", "1");
            tagRecord.Add("DConversion","Direct");
            tagRecord.Add("AccessName", "");
            tagRecord.Add("ItemUseTagname", "No");
            tagRecord.Add("ItemName", "");
            tagRecord.Add("ReadOnly", "No");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "0");
            tagRecord.Add("DSCAlarmDisable", "0");
            tagRecord.Add("DSCAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");
        }

        //Methods
        public void SetIODisc(string value)
        {
            tagRecord["IODisc"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }
        public void SetAlarmState(string value)
        {
            tagRecord["AlarmState"] = value;
        }
        public void SetAccessName(string value)
        {
            tagRecord["AccessName"] = value;
        }
        public void SetItemName(string value)
        {
            tagRecord["ItemName"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }

    class MemoryInt
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public MemoryInt()
        {

            tagRecord.Add("MemoryInt", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("RetentiveAlarmParameters", "No");
            tagRecord.Add("AlarmValueDeadband", "0");
            tagRecord.Add("AlarmDevDeadband", "0");
            tagRecord.Add("EngUnits", "");
            tagRecord.Add("InitialValue", "0");
            tagRecord.Add("MinValue", "-2147483648");
            tagRecord.Add("MaxValue", "2147483647");
            tagRecord.Add("Deadband", "0");
            tagRecord.Add("LogDeadband", "0");
            tagRecord.Add("LoLoAlarmState", "Off");
            tagRecord.Add("LoLoAlarmValue", "0");
            tagRecord.Add("LoLoAlarmPri", "1");
            tagRecord.Add("LoAlarmState", "Off");
            tagRecord.Add("LoAlarmValue", "0");
            tagRecord.Add("LoAlarmPri", "1");
            tagRecord.Add("HiAlarmState", "Off");
            tagRecord.Add("HiAlarmValue", "0");
            tagRecord.Add("HiAlarmPri", "1");
            tagRecord.Add("HiHiAlarmState", "Off");
            tagRecord.Add("HiHiAlarmValue", "0");
            tagRecord.Add("HiHiAlarmPri", "1");
            tagRecord.Add("MinorDevAlarmState", "Off");
            tagRecord.Add("MinorDevAlarmValue", "0");
            tagRecord.Add("MinorDevAlarmPri", "1");
            tagRecord.Add("MajorDevAlarmState", "Off");
            tagRecord.Add("MajorDevAlarmValue", "0");
            tagRecord.Add("MajorDevAlarmPri", "1");
            tagRecord.Add("DevTarget", "0");
            tagRecord.Add("ROCAlarmState", "Off");
            tagRecord.Add("ROCAlarmValue", "0");
            tagRecord.Add("ROCAlarmPri", "1");
            tagRecord.Add("ROCTimeBase", "Min");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "0");
            tagRecord.Add("LoLoAlarmDisable", "0");
            tagRecord.Add("LoAlarmDisable", "0");
            tagRecord.Add("HiAlarmDisable", "0");
            tagRecord.Add("HiHiAlarmDisable", "0");
            tagRecord.Add("MinDevAlarmDisable", "0");
            tagRecord.Add("MajDevAlarmDisable", "0");
            tagRecord.Add("RocAlarmDisable", "0");
            tagRecord.Add("LoLoAlarmInhibitor", "");
            tagRecord.Add("LoAlarmInhibitor", "");
            tagRecord.Add("HiAlarmInhibitor", "");
            tagRecord.Add("HiHiAlarmInhibitor", "");
            tagRecord.Add("MinDevAlarmInhibitor", "");
            tagRecord.Add("MajDevAlarmInhibitor", "");
            tagRecord.Add("RocAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");
        }

        //Methods
        public void SetMemoryInt(string value)
        {
            tagRecord["MemoryInt"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }

    class IOInt
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public IOInt()
        {

            tagRecord.Add("IOInt", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("RetentiveAlarmParameters", "No");
            tagRecord.Add("AlarmValueDeadband", "0");
            tagRecord.Add("AlarmDevDeadband", "0");
            tagRecord.Add("EngUnits", "");
            tagRecord.Add("InitialValue", "0");
            tagRecord.Add("MinEU", "-32768");
            tagRecord.Add("MaxEU", "32767");
            tagRecord.Add("Deadband", "0");
            tagRecord.Add("LogDeadband", "0");
            tagRecord.Add("LoLoAlarmState", "Off");
            tagRecord.Add("LoLoAlarmValue", "0");
            tagRecord.Add("LoLoAlarmPri", "1");
            tagRecord.Add("LoAlarmState", "Off");
            tagRecord.Add("LoAlarmValue", "0");
            tagRecord.Add("LoAlarmPri", "1");
            tagRecord.Add("HiAlarmState", "Off");
            tagRecord.Add("HiAlarmValue", "0");
            tagRecord.Add("HiAlarmPri", "1");
            tagRecord.Add("HiHiAlarmState", "Off");
            tagRecord.Add("HiHiAlarmValue", "0");
            tagRecord.Add("HiHiAlarmPri", "1");
            tagRecord.Add("MinorDevAlarmState", "Off");
            tagRecord.Add("MinorDevAlarmValue", "0");
            tagRecord.Add("MinorDevAlarmPri", "1");
            tagRecord.Add("MajorDevAlarmState", "Off");
            tagRecord.Add("MajorDevAlarmValue", "0");
            tagRecord.Add("MajorDevAlarmPri", "1");
            tagRecord.Add("DevTarget", "0");
            tagRecord.Add("ROCAlarmState", "Off");
            tagRecord.Add("ROCAlarmValue", "0");
            tagRecord.Add("ROCAlarmPri", "1");
            tagRecord.Add("ROCTimeBase", "Min");
            tagRecord.Add("MinRaw", "-32768");
            tagRecord.Add("MaxRaw", "32767");
            tagRecord.Add("Conversion", "Linear");
            tagRecord.Add("AccessName", "");
            tagRecord.Add("ItemUseTagname", "No");
            tagRecord.Add("ItemName", "");
            tagRecord.Add("ReadOnly", "No");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "0");
            tagRecord.Add("LoLoAlarmDisable", "0");
            tagRecord.Add("LoAlarmDisable", "0");
            tagRecord.Add("HiAlarmDisable", "0");
            tagRecord.Add("HiHiAlarmDisable", "0");
            tagRecord.Add("MinDevAlarmDisable", "0");
            tagRecord.Add("MajDevAlarmDisable", "0");
            tagRecord.Add("RocAlarmDisable", "0");
            tagRecord.Add("LoLoAlarmInhibitor", "");
            tagRecord.Add("LoAlarmInhibitor", "");
            tagRecord.Add("HiAlarmInhibitor", "");
            tagRecord.Add("HiHiAlarmInhibitor", "");
            tagRecord.Add("MinDevAlarmInhibitor", "");
            tagRecord.Add("MajDevAlarmInhibitor", "");
            tagRecord.Add("RocAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");

        }

        //Methods
        public void SetIOInt(string value)
        {
            tagRecord["IOInt"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }
        public void SetAccessName(string value)
        {
            tagRecord["AccessName"] = value;
        }
        public void SetItemName(string value)
        {
            tagRecord["ItemName"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }

    class MemoryReal
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public MemoryReal()
        {

            tagRecord.Add("MemoryReal", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("RetentiveAlarmParameters", "No");
            tagRecord.Add("AlarmValueDeadband", "0");
            tagRecord.Add("AlarmDevDeadband", "0");
            tagRecord.Add("EngUnits", "");
            tagRecord.Add("InitialValue", "0");
            tagRecord.Add("MinValue", "-32768");
            tagRecord.Add("MaxValue", "32767");
            tagRecord.Add("Deadband", "0");
            tagRecord.Add("LogDeadband", "0");
            tagRecord.Add("LoLoAlarmState", "Off");
            tagRecord.Add("LoLoAlarmValue", "0");
            tagRecord.Add("LoLoAlarmPri", "1");
            tagRecord.Add("LoAlarmState", "Off");
            tagRecord.Add("LoAlarmValue", "0");
            tagRecord.Add("LoAlarmPri", "1");
            tagRecord.Add("HiAlarmState", "Off");
            tagRecord.Add("HiAlarmValue", "0");
            tagRecord.Add("HiAlarmPri", "1");
            tagRecord.Add("HiHiAlarmState", "Off");
            tagRecord.Add("HiHiAlarmValue", "0");
            tagRecord.Add("HiHiAlarmPri", "1");
            tagRecord.Add("MinorDevAlarmState", "Off");
            tagRecord.Add("MinorDevAlarmValue", "0");
            tagRecord.Add("MinorDevAlarmPri", "1");
            tagRecord.Add("MajorDevAlarmState", "Off");
            tagRecord.Add("MajorDevAlarmValue", "0");
            tagRecord.Add("MajorDevAlarmPri", "1");
            tagRecord.Add("DevTarget", "0");
            tagRecord.Add("ROCAlarmState", "Off");
            tagRecord.Add("ROCAlarmValue", "0");
            tagRecord.Add("ROCAlarmPri", "1");
            tagRecord.Add("ROCTimeBase", "Min");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "0");
            tagRecord.Add("LoLoAlarmDisable", "0");
            tagRecord.Add("LoAlarmDisable", "0");
            tagRecord.Add("HiAlarmDisable", "0");
            tagRecord.Add("HiHiAlarmDisable", "0");
            tagRecord.Add("MinDevAlarmDisable", "0");
            tagRecord.Add("MajDevAlarmDisable", "0");
            tagRecord.Add("RocAlarmDisable", "0");
            tagRecord.Add("LoLoAlarmInhibitor", "");
            tagRecord.Add("LoAlarmInhibitor", "");
            tagRecord.Add("HiAlarmInhibitor", "");
            tagRecord.Add("HiHiAlarmInhibitor", "");
            tagRecord.Add("MinDevAlarmInhibitor", "");
            tagRecord.Add("MajDevAlarmInhibitor", "");
            tagRecord.Add("RocAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");
        }

        //Methods
        public void SetMemoryReal(string value)
        {
            tagRecord["MemoryReal"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }
    class IOReal
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public IOReal()
        {

            tagRecord.Add("IOReal", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("RetentiveAlarmParameters", "No");
            tagRecord.Add("AlarmValueDeadband", "0");
            tagRecord.Add("AlarmDevDeadband", "0");
            tagRecord.Add("EngUnits", "");
            tagRecord.Add("InitialValue", "0");
            tagRecord.Add("MinEU", "-32768");
            tagRecord.Add("MaxEU", "32767");
            tagRecord.Add("Deadband", "0");
            tagRecord.Add("LogDeadband", "0");
            tagRecord.Add("LoLoAlarmState", "Off");
            tagRecord.Add("LoLoAlarmValue", "0");
            tagRecord.Add("LoLoAlarmPri", "0");
            tagRecord.Add("LoAlarmState", "Off");
            tagRecord.Add("LoAlarmValue", "0");
            tagRecord.Add("LoAlarmPri", "0");
            tagRecord.Add("HiAlarmState", "Off");
            tagRecord.Add("HiAlarmValue", "0");
            tagRecord.Add("HiAlarmPri", "0");
            tagRecord.Add("HiHiAlarmState", "Off");
            tagRecord.Add("HiHiAlarmValue", "0");
            tagRecord.Add("HiHiAlarmPri", "0");
            tagRecord.Add("MinorDevAlarmState", "Off");
            tagRecord.Add("MinorDevAlarmValue", "0");
            tagRecord.Add("MinorDevAlarmPri", "1");
            tagRecord.Add("MajorDevAlarmState", "Off");
            tagRecord.Add("MajorDevAlarmValue", "0");
            tagRecord.Add("MajorDevAlarmPri", "1");
            tagRecord.Add("DevTarget", "0");
            tagRecord.Add("ROCAlarmState", "Off");
            tagRecord.Add("ROCAlarmValue", "0");
            tagRecord.Add("ROCAlarmPri", "1");
            tagRecord.Add("ROCTimeBase", "Min");
            tagRecord.Add("MinRaw", "-32768");
            tagRecord.Add("MaxRaw", "32767");
            tagRecord.Add("Conversion", "Linear");
            tagRecord.Add("AccessName", "");
            tagRecord.Add("ItemUseTagname", "No");
            tagRecord.Add("ItemName", "");
            tagRecord.Add("ReadOnly", "No");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("AlarmAckModel", "2");
            tagRecord.Add("LoLoAlarmDisable", "0");
            tagRecord.Add("LoAlarmDisable", "0");
            tagRecord.Add("HiAlarmDisable", "0");
            tagRecord.Add("HiHiAlarmDisable", "0");
            tagRecord.Add("MinDevAlarmDisable", "0");
            tagRecord.Add("MajDevAlarmDisable", "0");
            tagRecord.Add("RocAlarmDisable", "0");
            tagRecord.Add("LoLoAlarmInhibitor", "");
            tagRecord.Add("LoAlarmInhibitor", "");
            tagRecord.Add("HiAlarmInhibitor", "");
            tagRecord.Add("HiHiAlarmInhibitor", "");
            tagRecord.Add("MinDevAlarmInhibitor", "");
            tagRecord.Add("MajDevAlarmInhibitor", "");
            tagRecord.Add("RocAlarmInhibitor", "");
            tagRecord.Add("SymbolicName", "");


        }

        //Methods
        public void SetIOReal(string value)
        {
            tagRecord["IOReal"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }
        public void SetAccessName(string value)
        {
            tagRecord["AccessName"] = value;
        }
        public void SetItemName(string value)
        {
            tagRecord["ItemName"] = value;
        }
		public void SetLogged(string value)
		{
			tagRecord["Logged"] = value;
		}
		public void SetLoLoAlarmState(string value)
		{
			tagRecord["LoLoAlarmState"] = value;
		}
		public void SetLoAlarmState(string value)
		{
			tagRecord["LoAlarmState"] = value;
		}
		public void SetHiHiAlarmState(string value)
		{
			tagRecord["HiHiAlarmState"] = value;
		}
		public void SetHiAlarmState(string value)
		{
			tagRecord["HiAlarmState"] = value;
		}
		public void SetLoLoAlarmValue(string value)
		{
			tagRecord["LoLoAlarmValue"] = value;
		}
		public void SetLoAlarmValue(string value)
		{
			tagRecord["LoAlarmValue"] = value;
		}
		public void SetHiHiAlarmValue(string value)
		{
			tagRecord["HiHiAlarmValue"] = value;
		}
		public void SetHiAlarmValue(string value)
		{
			tagRecord["HiAlarmValue"] = value;
		}

		public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }
    class MemoryMsg
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public MemoryMsg()
        {

            tagRecord.Add("MemoryMsg", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("MaxLength", "131");
            tagRecord.Add("InitialMessage", "");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("SymbolicName", "");
        }

        //Methods
        public void SetMemoryMsg(string value)
        {
            tagRecord["MemoryMsg"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }

    class IOMsg
    {
        //declare fields or local variable

        Dictionary<string, string> tagRecord = new Dictionary<string, string>();

        //create Constructor, if it possible refactor with inheritance


        public IOMsg()
        {

            tagRecord.Add("IOMsg", "");
            tagRecord.Add("Group", "$System");
            tagRecord.Add("Comment", "");
            tagRecord.Add("Logged", "No");
            tagRecord.Add("EventLogged", "No");
            tagRecord.Add("EventLoggingPriority", "0");
            tagRecord.Add("RetentiveValue", "No");
            tagRecord.Add("MaxLength", "131");
            tagRecord.Add("InitialMessage", "");
            tagRecord.Add("AccessName", "");
            tagRecord.Add("ItemUseTagname", "No");
            tagRecord.Add("ItemName", "");
            tagRecord.Add("ReadOnly", "No");
            tagRecord.Add("AlarmComment", "");
            tagRecord.Add("SymbolicName", "");


        }

        //Methods
        public void SetIOMsg(string value)
        {
            tagRecord["IOMsg"] = value;
        }
        public void SetGroup(string value)
        {
            tagRecord["Group"] = value;
        }
        public void SetAccessName(string value)
        {
            tagRecord["AccessName"] = value;
        }
        public void SetItemName(string value)
        {
            tagRecord["ItemName"] = value;
        }

        public string CSVSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Value + ",";
            }
            return record;
        }
        public string CSVTitleSerialize()
        {
            string record = "";
            foreach (KeyValuePair<string, string> kvp in tagRecord)
            {
                record = record + kvp.Key + ",";
            }
            return ":" + record;
        }

    }





}
