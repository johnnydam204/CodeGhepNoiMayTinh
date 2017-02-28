#include <xc.h>
#include <stdio.h>
#include <string.h>

#include "main.h"
#include "myLCD.h"
#include "myUart.h"

char buffer[64];

void main()
{
    lcd_init();
    uartOpen();
    
    lcd_puts("Xin chao");
    
    while(1)
    {
        uartGets(&buffer[0],16);
        lcd_gotoxy(0,2);
        lcd_puts(&buffer[0]);
    }
}
