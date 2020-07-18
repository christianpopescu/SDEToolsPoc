#include "ncurses.h"
#include<bits/stdc++.h> 
void bomb(char *msg)
{
 endwin();
 puts(msg);
 _Exit(1);
}

int main()
{
	initscr(); /* Start curses mode */
    attron(A_BOLD);
    addstr("Twinkle, twinkle little star\n");
    attron(A_BLINK);
    addstr("Bliniking\n");
    if(start_color() != OK)
        bomb("Unable to start colors.\n");
    printw("NCurses reports that you can use %d colors,\n",COLORS);
    printw("and %d color pairs.",COLOR_PAIRS);
    int x,y;
    getmaxyx(stdscr,y,x);
    printw("Window size is %d rows, %d columns.\n",y,x);
	start_color();
    init_pair(1,COLOR_WHITE,COLOR_BLUE);
    bkgd(COLOR_PAIR(1)); 
	refresh(); /* Print it on to the real screen */
    x--;
    y--;
    move(0,0); /* UL corner */
    addch('*');
    refresh();
    napms(500); /* pause half a sec. */
    
    move(0,x); /* UR corner */
    addch('*');
    refresh();
    napms(500);

    move(y,0); /* LL corner */
    addch('*');
    refresh();
    napms(500);
    
    move(y,x); /* LR corner */    
    addch('*');
    refresh();
    napms(500);
	getch(); /* Wait for user input */
	endwin(); /* End curses mode */
	return 0;
}

