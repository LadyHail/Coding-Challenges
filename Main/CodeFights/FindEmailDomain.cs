/* 
 DESCRIPTION:
 An email address such as "John.Smith@example.com" is made up of a local part ("John.Smith"), an "@" symbol, then a domain part ("example.com").
 The domain name part of an email address may only consist of letters, digits, hyphens and dots. The local part, however, also allows a lot of different special characters. Here you can look at several examples of correct and incorrect email addresses.
 Given a valid email address, find its domain part.
 Example
     For address = "prettyandsimple@example.com", the output should be
    findEmailDomain(address) = "example.com";
    For address = "<>[]:,;@"!#$%&*+-/=?^_{}| ~.a"@example.org", the output should be
    findEmailDomain(address) = "example.org".
*/

namespace Main.CodeFights
{
    public static class FindEmailDomain
    {
        public static string findEmailDomain(string address)
        {
            int index = address.LastIndexOf('@');
            return address.Substring(index + 1);
        }
    }
}
