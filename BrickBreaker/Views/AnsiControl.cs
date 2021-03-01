using System;
using System.Collections.Generic;
using System.Reflection;//i like reflection, okay? 
using System.Text;

namespace BrickBreaker.Views
{


    static public class AnsiControl
    {
        public static string BLACK      = "\u001b[30m";
        public static string RED        = "\u001b[31m";
        public static string GREEN      = "\u001b[32m";
        public static string YELLOW     = "\u001b[33m";
        public static string BLUE       = "\u001b[34m";
        public static string MAGENTA    = "\u001b[35m";
        public static string CYAN       = "\u001b[36m";
        public static string WHITE      = "\u001b[37m";
        public static string RESET      = "\u001b[0m";
        public static string CLEAR      = "\u001b[2J";

        public static string MoveCursor(int x, int y)
        {
            return $"\u001b[{y};{x}H";

        }


        /// <summary>
        /// Since this is gonna be run ALOT, we might as well cache this list so we can use it again.
        /// Its not like we can add new ANSI command strings at runtime
        /// </summary>
        private static List<string> commandStrings = new List<string>();

        /// <summary>
        /// Gets a list of all the ANSI Control sequence strings that we know about.
        /// </summary>
        /// <returns>a List<list type="string">All the ANSI Escape "characters" 
        /// (really they're strings but lets not split hairs, okay?)</list></returns>
        public static List<string> CommandStrings
        {
            get
            {
                if (commandStrings.Count == 0)//whoops! looks like we gotta do this for the first time
                {
                    FieldInfo[] fields = typeof(AnsiControl).GetFields();
                    foreach (FieldInfo field in fields)
                    {
                        if (field.FieldType == typeof(string))
                        {
                            commandStrings.Add((string)field.GetValue(null));
                        }
                    }
                }
                return commandStrings;
            }
        }

        public static string StripAnsi(string stringToStrip)
        {
            StringBuilder sb = new StringBuilder(stringToStrip);
            foreach (string commandString in AnsiControl.CommandStrings)
            {
                sb.Replace(commandString, "");
            }
            return sb.ToString();
        }


    }

}
