using System;
using System.Linq;
using System.Text;

namespace BinaryStringTask
{
    /// <summary>
    /// <c>Class BinaryString</c>
    /// </summary>
    public static class BinaryString
    {
        /// <summary>
        /// Method checks the validity of a binary string.
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>If the string is binary return true otherwise false.</returns>
        /// <exception cref="ArgumentException">If string value is empty.</exception>
        /// <exception cref="ArgumentNullException">If string vlue is null.</exception>
        public static bool IsValidBinaryString(this string value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), "value can not be null");
            }

            if (value == string.Empty)
            {
                throw new ArgumentException(nameof(value), "value can not be empty");
            }

            if (!IsValidCount(value))
            {
                return false;
            }
            else
            {
                StringBuilder builder = new StringBuilder();

                foreach (var item in value)
                {
                    var prefix = builder.Append(item);

                    if (!IsValidPrefix(prefix.ToString()))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private static bool IsValidCount(string source)
        {
            var numberOfZeros = source.Count(c => c == '0');
            var numberOfUnits = source.Length - numberOfZeros;

            return numberOfUnits == numberOfZeros;
        }

        private static bool IsValidPrefix(string source)
        {
            var numberOfZeros = source.Count(c => c == '0');
            var numberOfUnits = source.Length - numberOfZeros;

            return numberOfUnits >= numberOfZeros;
        }
    }
}
