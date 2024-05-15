Console.WriteLine(RomanToInt("MCMXCIV"));

int RomanToInt(string s)
{
    int num = 0;

    string[] partials = Enum.GetNames(typeof(PartialRomanNumbers));

    foreach (var partial in partials)
    {
        if (s.Contains(partial))
        {
            num += (int)Enum.Parse<PartialRomanNumbers>(partial);
            s = s.Replace(partial, "");
        }
    }
    
    foreach (char character in s)
    {
        int number = (int)Enum.Parse<FullRomanNumbers>(character.ToString());
        num += number;
    }
    
    return num;
}

public enum FullRomanNumbers {
     I = 1,
     V = 5,
     X = 10,
     L = 50,
     C = 100,
     D = 500,
     M = 1000
 }
 
public enum PartialRomanNumbers {
    IV = 4,
    IX = 9,
    XL = 40,
    XC = 90,
    CD = 400,
    CM = 900
}