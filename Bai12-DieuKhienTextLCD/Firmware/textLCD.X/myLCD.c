#include <xc.h>
#include "myLCD.h"
#include "main.h"

// Ham truyen di nua byte
void lcd_nible(char nible)
{
    LCD_D4 = (nible >> 4) & 0x01;
    LCD_D5 = (nible >> 5) & 0x01;
    LCD_D6 = (nible >> 6) & 0x01;
    LCD_D7 = (nible >> 7) & 0x01;
    
    LCD_EN = 1;
    __delay_us(10);
    LCD_EN = 0;
    __delay_us(50);
}

// Ham truyen di ca byte
void lcd_byte(char byte)
{
    lcd_nible(byte);
    lcd_nible(byte << 4);
    __delay_us(10);
}

// Ham truyen di ma lenh
void lcd_cmd(char cmd)
{
    LCD_RS = 0; // Thanh ghi lenh
    LCD_RW = 0;
    lcd_byte(cmd);
}

// Ham truyen di ky tu
void lcd_putc(char chr)
{
    LCD_RS = 1; // Thanh ghi du lieu
    LCD_RW = 0;
    lcd_byte(chr);
}

// Ham truyen di chuoi ky tu
void lcd_puts(char *str)
{
    while(*str)
    {
        lcd_putc(*str);
        str++;
    }
}

// Ham xac dinh toa do hien thi (toa do con tro)
void lcd_gotoxy(char col, char row)
{
    if(row == 1) lcd_cmd(0x80 + col);
    if(row == 2) lcd_cmd(0xC0 + col);
    if(row == 3) lcd_cmd(0x94 + col);
    if(row == 4) lcd_cmd(0xD4 + col);
}

// Ham khoi tao LCD
void lcd_init(void)
{
    // Thiet lap chan dieu khien LCD la dau ra
    LCD_D4_TRIS = 0;
    LCD_D5_TRIS = 0;
    LCD_D6_TRIS = 0;
    LCD_D7_TRIS = 0;
    
    LCD_RS_TRIS = 0;
    LCD_RW_TRIS = 0;
    LCD_EN_TRIS = 0;
    
    // Lam thieo luu do thuat toan LCD-4bit Interfaces
    __delay_ms(20); 
    lcd_nible(0x30);
            
    __delay_ms(20); 
    lcd_nible(0x30);
    
    __delay_ms(20); 
    lcd_nible(0x30);
    
    __delay_ms(20); 
    lcd_nible(0x20); // Thiet lap giao thuc la 4bit
    
    lcd_cmd(0x28); // lcd tu 2 dong tro len, font 5x8  
    lcd_cmd(0x0C); // bat hien thi, tat con tro
    lcd_cmd(0x06); // Hien thi tang len mot don vi
    lcd_cmd(0x01); // Xoa hien thi
    lcd_cmd(0x02); // Dua con tro ve dau dong
    
    __delay_ms(50); 
}
