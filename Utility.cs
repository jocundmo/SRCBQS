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

        public static Model.Answer.Symbol ConvertToSymbol(string sym)
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

        public static Model.Question.Typee ConvertToTypee(string type)
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

        public static Model.Answer.Symbol ConvertToSymbol(int index)
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

        public static int MoreCharToInt(string value)
        {
            int rtn = 0;
            int powIndex = 0;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                int tmpInt = value[i];
                tmpInt -= 64;

                rtn += (int)Math.Pow(26, powIndex) * tmpInt;
                powIndex++;
            }

            return rtn;
        }

        public static string IntToMoreChar(int value)
        {
            string rtn = string.Empty;
            List<int> iList = new List<int>();

            //To single Int
            while (value / 26 != 0 || value % 26 != 0)
            {
                iList.Add(value % 26);
                value /= 26;
            }

            //Change 0 To 26
            for (int j = 0; j < iList.Count - 1; j++)
            {
                if (iList[j] == 0)
                {
                    iList[j + 1] -= 1;
                    iList[j] = 26;
                }
            }

            //Remove 0 at last
            if (iList[iList.Count - 1] == 0)
            {
                iList.Remove(iList[iList.Count - 1]);
            }

            //To String
            for (int j = iList.Count - 1; j >= 0; j--)
            {
                char c = (char)(iList[j] + 64);
                rtn += c.ToString();
            }

            return rtn;
        }
    }
}
