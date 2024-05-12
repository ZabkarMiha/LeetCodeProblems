Console.WriteLine(isPalindrome(101)); 

bool isPalindrome(int x)
{
    if (x < 0) return false;

    int xCopy = x;
    
    int reversed = 0;

    while (x > 0)
    {
        int lastDigit = x % 10;
        
        reversed = (reversed * 10) + lastDigit;

        x = x / 10;
    }

    return xCopy == reversed;
}