using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SRCBQuestionnaireStatistic
{
    public static class Utility
    {
        public static string GetAttributeValue(XmlNode node, string key, string defaultValue)
        {
            XmlAttribute attribute = null;
            foreach (XmlAttribute attr in node.Attributes)
            {
                if (attr.Name.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    attribute = attr;
                    break;
                }
            }

            string result = defaultValue;

            if (attribute != null)
                result = attribute.Value.Trim();

            return result;
        }

        internal static Model.Answer.Symbol ConvertToSymbol(string sym)
        {
            switch (sym)
            {
                case "A":
                    return Model.Answer.Symbol.A;
                case "B":
                    return Model.Answer.Symbol.B;
                case "C":
                    return Model.Answer.Symbol.C;
                case "D":
                    return Model.Answer.Symbol.D;
                case "E":
                    return Model.Answer.Symbol.E;
                default:
                    throw new NotSupportedException(string.Format("{0} is not supported", sym));
            }
        }

        internal static Model.Question.Typee ConvertToTypee(string type)
        {
            switch (type)
            {
                case "SingleChoice":
                    return Model.Question.Typee.SingleChoice;
                case "MultipleChoices":
                    return Model.Question.Typee.MultipleChoices;
                default:
                    throw new NotSupportedException(string.Format("{0} is not supported", type));
            }
        }

        internal static Model.Answer.Symbol ConvertToSymbol(int index)
        {
            switch (index)
            {
                case 0:
                    return Model.Answer.Symbol.A;
                case 1:
                    return Model.Answer.Symbol.B;
                case 2:
                    return Model.Answer.Symbol.C;
                case 3:
                    return Model.Answer.Symbol.D;
                case 4:
                    return Model.Answer.Symbol.E;
                default:
                    throw new NotSupportedException(string.Format("{0} is not supported", index));
            }
        }
    }
}
