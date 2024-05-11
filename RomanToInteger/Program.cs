/*For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.
 The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right.
However, the numeral for four is not IIII. Instead, the number four is written as IV.
Because the one is before the five we subtract it making four.
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9.
X can be placed before L (50) and C (100) to make 40 and 90.
C can be placed before D (500) and M (1000) to make 400 and 900.*/

Console.WriteLine(RomanToInt("IV"));

int RomanToInt(string s)
{
    int num = 0;
    if (s.Contains("IV")) num += 4;
    
    foreach (char character in s)
    {
        int number = (int)Enum.Parse<RomanNumbers>(character.ToString());
        num += number;
    }
    
    return num;
}

public enum RomanNumbers {
    I = 1,
    VI = 4,
    V = 5,
    XI = 9,
    X = 10,
    XL = 40,
    L = 50,
    XC = 90,
    C = 100,
    CD = 400,
    D = 500,
    CM = 900,
    M = 1000
}