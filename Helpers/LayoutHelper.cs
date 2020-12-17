using System;
using System.Collections.Generic;

namespace chatbot.Helpers
{
    public class LayoutHelper
    {
        public static Dictionary<string, string> GetHeaderPages()
        {
            return new Dictionary<string, string>
            {
                {"Index", "Home"},
                {"Privacy", "Privacy"}
            };
        }
    }
}
