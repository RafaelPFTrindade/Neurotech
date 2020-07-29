using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Domain.Results
{

    public class Resultado
    {
        public string OperationCode { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RulesResults Result { get; set; }
    }

    public class RulesResults
    {
        public string Result { get; set; }
        public Output[] Outputs { get; set; }
        public RuleResult[] RuleResults { get; set; }
    }

    public class Output
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public object Type { get; set; }
    }

    public class RuleResult
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string RuleDescription { get; set; }
        public string ResultCompleteDescription { get; set; }
        public string ResultSimpleDescription { get; set; }
        public Input[] Inputs { get; set; }
        public string ParentRuleName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Input
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public object Order { get; set; }
        public object Visible { get; set; }
    }
}
