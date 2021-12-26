#include <stdio.h>

int main(void)
{
    // your code goes here
    int withdraw = 0;
    double balance = 0;

    scanf("%d", &withdraw);
    scanf("%lf", &balance);

    if ((withdraw % 5) == 0)
    {
        if (((double)withdraw + 0.5) < balance)
        {
            printf("%.2f", (balance - ((double)withdraw + 0.5)));
        }
        else
        {
            printf("%.2f", balance);
        }
    }
    else
    {
        printf("%.2f", balance);
    }

    return 0;
}
