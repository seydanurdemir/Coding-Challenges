int solution(int number)
{
    // code here
    int i = 0;   // index counter for for loop
    int som = 0; // sum of multiplies

    if (number < 3)
        return 0;

    for (i = 3; i < number; i++)
    {
        if ((i % 3) == 0)
        {
            som += i;
        }
        else if ((i % 5) == 0)
        {
            som += i;
        }
    }

    return som;
}