using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

    class Conversion
    {
        //public static int ConvertToInt32(string value, int valueIfCannotConvert)
        //{

        //}
        public static DateTime ConvertToDateFromXML(string value, DateTime valueIfCannotConvert)
        {
            if (value.Length < 5)
            {
                // cannot be valid date passed in
                return valueIfCannotConvert;
            }
            else
            {
                try
                {
                    return XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Unspecified);
                }
                catch (Exception ex)
                {
                    // Try converting without the time
                    if (value.IndexOf("T") > 0)
                    {
                        string strDateOnly = value.Substring(0, value.IndexOf("T"));
                        return Convert.ToDateTime(strDateOnly);
                    }
                    // Nothing worked, return failure value
                    return valueIfCannotConvert;
                }
            }
        }
    }
