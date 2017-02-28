#include <xc.h>
#include <stdio.h>

#include "main.h"
#include "myADC.h"
#include "myLCD.h"
#include "myUart.h"

char buff[86];
unsigned int ad;

void main()
{
    lcdInit();
    uartOpen();
    adcInit();
    
    lcdPuts("DO ADC");
    while(1)
    {
        ad = adcRead(0);
        sprintf(&buff[0],"%0.4d",ad);
        lcdGotoxy(0,2);
        lcdPuts(&buff[0]);
        uartPuts(&buff[0]);
        uartPuts("\n");
        __delay_ms(300);
    }
}
