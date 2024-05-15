Console.WriteLine(LongestCommonPrefix(["flow","flight"]));

string LongestCommonPrefix(string[] strs)
{
    if (strs.Contains("")) return "";
    
    if (strs.Length == 1) return strs[0];

    string prefix = strs.First();
    
    foreach (var word in strs.Skip(1))
    {
        prefix = FindPrefix(prefix, word);
    }

    return prefix;
}

string FindPrefix(string one, string two)
{
    string prefix = string.Empty;

    if (one is "") return "";

    if (one[0] != two[0]) return "";

    int length = one.Length < two.Length ? one.Length : two.Length;

    for (int i = 0; i < length; i++)
    {
        if (one[i] == two[i])
            prefix += one[i];
        else
            break;
    }
    
    return prefix;
}