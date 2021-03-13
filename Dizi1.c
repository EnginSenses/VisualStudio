#include <stdio.h>
main()
{
    int teksayiler[10]={1,3,5,7,9,11,13,15,17,19};
    int i,toplam=0;
    for (i=0;i<=9;i++)
    {
        printf("\nSayi dizisinin %d. Elemani %d",i+1,teksayiler[i]);
        
    }
    i=0;
    do
    {
        toplam=toplam+teksayiler[i];
        i++;
    } 
    while (i<=9);
    {
    printf("\nSayilarin Toplami :%d",toplam);
    }
}