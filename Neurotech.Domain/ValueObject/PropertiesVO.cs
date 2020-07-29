using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Domain
{
    public class PropertiesVO
    {
        public PropertiesVO(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
