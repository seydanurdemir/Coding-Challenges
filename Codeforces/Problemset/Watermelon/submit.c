#include <stdio.h>

int main (void)
{
    /* Read w from stdin */
    int w = 0;
    scanf("%d", &w);
    
    /* Write result to stdout */
    if ((w % 2) == 1)
    {
        printf("NO");
    }
    else
    {
        if (w == 2)
        {
            printf("NO");
        }
        else
        {
            printf("YES");
        }
    }
    
    return 0;
}