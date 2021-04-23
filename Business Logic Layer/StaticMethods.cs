using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using static System.StringComparison;

namespace Library_Juggle.Business_Logic_Layer
{
    internal static class StaticMethods
    {
        public static string CreateMd5(string input)
        {
            
            using var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public static List<ValidationResult> GetModelErrors(this object entity)
        {
            var errorList = new List<ValidationResult>();
            Validator.TryValidateObject(entity, new ValidationContext(entity, null, null), errorList);
            return errorList.Count != 0 ? errorList : null;
        }
        public static int ParseKeyValuePairObject(object obj)
        {
            var tempString = obj.ToString();
            var start = tempString!.IndexOf("[", Ordinal) + 1;
            var end = tempString!.IndexOf(",", start, Ordinal);
            return int.Parse(tempString![start..end]);
        }
    }
}
