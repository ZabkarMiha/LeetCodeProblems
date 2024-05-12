/*For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.
 The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right.
However, the numeral for four is not IIII. Instead, the number four is written as IV.
Because the one is before the five we subtract it making four.
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9.
X can be placed before L (50) and C (100) to make 40 and 90.
C can be placed before D (500) and M (1000) to make 400 and 900.*/

Console.WriteLine(RomanToInt("MCMXCIV"));

int RomanToInt(string s)
{
    int num = 0;

    string[] partials = Enum.GetNames(typeof(PartialRomanNumbers));

    foreach (var partial in partials)
    {
        Console.WriteLine(s);
        
        if (s.Contains(partial))
        {
            num += (int)Enum.Parse<PartialRomanNumbers>(partial);
            s = s.Replace(partial, "");
        }
    }
    
    Console.WriteLine("String: {0}\nNumber: {1}", s, num);
    
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