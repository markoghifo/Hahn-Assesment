using Business.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helper
{
    public class IntListToStringValueConverter : ValueConverter<ICollection<int>, string>
    {
        public IntListToStringValueConverter() : base(le => ListToString(le), (s => StringToList(s)))
        {

        }
        public static string? ListToString(ICollection<int> values)
        {
            if (values == null || values.Count() == 0)
            {
                return null;
            }

            return string.Join(',', values);
        }

        public static ICollection<int>? StringToList(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return (ICollection<int>?)value.Split(',').Select(i => Convert.ToInt32(i));

        }
    }

    public class StringListToStringValueConverter : ValueConverter<ICollection<string>, string>
    {
        public StringListToStringValueConverter() : base(le => ListToString(le), (s => StringToList(s)))
        {

        }
        public static string? ListToString(ICollection<string> values)
        {
            if (values == null || values.Count() == 0)
            {
                return null;
            }

            return string.Join(',', values);
        }

        public static ICollection<string>? StringToList(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return (ICollection<string>?)value.Split(',').Select(i => i); 

        }
    }

    public class EnumToStringValueConverted : ValueConverter<ContactType, string>
    {
        public EnumToStringValueConverted() : base(le => EnumToString(le), s => (ContactType)StringToEnum(s))
        {

        }

        public static string EnumToString(ContactType value)
        {
            return value.ToString().Replace("_", " ");
        }

        public static ContactType? StringToEnum(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            value = value.Replace(" ", "_");

            Enum.TryParse<ContactType>(value, true, out var contactType);
            return contactType;
        }
    }
}
