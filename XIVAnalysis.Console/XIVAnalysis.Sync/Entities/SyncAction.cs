using System;
using System.Text.RegularExpressions;

namespace XIVAnalysis.Sync.Entities
{
    public class SyncAction
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string IconAddress { get; set; }
        public bool OnGCD { get; set; }
        public decimal CastTime { get; set; }
        public decimal Cooldown { get; set; }
        public string JSActionName { get { return ConvertNameToJSName(); } private set { } }

        private string ConvertNameToJSName()
        {
            string result = String.Empty;

            Regex pattern = new Regex(@"[-\s]");
            result = pattern.Replace(Name, "_");

            return result;
        }
    }
}
