namespace SideMenuDesign.Extensions;

public static class StringExtensions
{
    public static string RemoveTailwindPrefix(this string value)
    {
        var index = value.IndexOf("-") + 1;
        return value.Substring(index, value.Length - index);
    }
}