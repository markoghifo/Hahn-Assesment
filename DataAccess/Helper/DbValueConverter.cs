using Business.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
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

            return value.Split(',').Select(i => Convert.ToInt32(i)).ToList();

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

            return value.Split(',').Select(i => i).ToList(); 

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

    public class TypeListToStringListValueConversion<T> : ValueConverter<ICollection<T>, string>
    {
        public TypeListToStringListValueConversion() : base(le => ListToString(le), (s => StringToList(s)))
        {

        }
        public static string? ListToString(ICollection<T> values)
        {
            if (values == null || values.Count() == 0)
            {
                return null;
            }

            return JsonConvert.SerializeObject(values);
        }

        public static ICollection<T>? StringToList(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<ICollection<T>>(value);
        }
    }
}
