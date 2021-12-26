#include <stdio.h>

int main(void)
{
    // your code goes here
    int withdraw;
    float balance;

    scanf("%d", &withdraw);
    scanf("%f", &balance);

    if (((withdraw % 5) == 0) && (((float)withdraw + 0.5) <= balance))
    {
        printf("%.2f", (balance - ((float)withdraw + 0.5)));
    }
    else
    {
        printf("%.2f", balance);
    }

    return 0;
}
