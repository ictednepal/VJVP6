namespace a_regex;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // string check = "a";
        // bool result = Regex.IsMatch(check, "[a-z]"); // true

        // string check = "s";
        // bool result = Regex.IsMatch(check, "[a-j]"); // false

        // string check = "aj";
        // bool result = Regex.IsMatch(check, "[a-f]"); // true

        // string check = "aj";
        // bool result = Regex.IsMatch(check, "^[a-f]$"); // false

        // string check = "ab";
        // bool result = Regex.IsMatch(check, "^[a-f]{5}$"); // false

        // string check = "abcde";
        // bool result = Regex.IsMatch(check, "^[a-f]{5}$"); // true

        // string check = "ab";
        // bool result = Regex.IsMatch(check, "^[a-f]{1,5}$"); // true

        // string check = "Ram";
        // bool result = Regex.IsMatch(check, "^[a-z]{1,5}$"); // False

        // string check = "Ram";
        // bool result = Regex.IsMatch(check, "^[a-zA-Z]{1,5}$"); // True

        // string check = "ramthapa";
        // bool result = Regex.IsMatch(check, "^[a-z]{1,8}$"); // true

        // string check = "9";
        // bool result = Regex.IsMatch(check, "[0-9]"); // true

        // string check = "123";
        // bool result = Regex.IsMatch(check, "^[0-9]{1,5}$"); // true

        // string check = "mallabiju@gmail.com";
            // bool result = Regex.IsMatch(check,"^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.(com)$"); //true

            // string check = "mallabiju@gmail.com.np";
            // bool result = Regex.IsMatch(check,"^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.(com)$"); //false

            // string check = "mallabiju@gmail.com.np";
            // bool result = Regex.IsMatch(check,"^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.(com|com.np)$"); //true

            // string check = "mallabiju@sanothimicampus.edu.np";
            // bool result = Regex.IsMatch(check,"^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.(com|com.np)$"); //false

            string check = "mallabiju@sanothimicampus.edu.np";
            bool result = Regex.IsMatch(check,"^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{3,20}.(com|com.np|edu.np)$"); //true


        Console.WriteLine(result);
    }
}
