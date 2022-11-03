const int PIRATE = 1;
const int STONECHEWER = 2;
const int GHOSTWARRIOR = 3;
const int OUTWORLDER = 4;
const int MONSTERKNIGHT = 5;
const int DARKGOBLIN = 6;

const int PIRATE_HEALTH = 20;

Console.WriteLine("Player1 what is your character role of the fighter? (1)pirate/(2)stone chewer/ (3)ghost warrior/ (4)OUT WORLDER/ (5) MONSTER KNIGHT/ (6) DARK GOBLIN");
int player1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Player2 what is your character role of the fighter? (1)pirate/ (2)stone chewer/ (3)ghost warrior/ (4)OUT WORLDER/ (5) MONSTER KNIGHT/ (6) DARK GOBLIN");
int player2 = int.Parse(Console.ReadLine()!);

double health1 = 0;
double health2 = 0;
double attack1 = 0;
double attack2 = 0;
double armor1 = 0;
double armor2 = 0;
int speed1 = 0;
int speed2 = 0;

if (player1 == PIRATE)
{
    health1 = PIRATE_HEALTH + 3;
    attack1 = 3;
    armor1 = 3;
    speed1 = 3;
}
if (player1 == STONECHEWER)
{
    health1 = 50 + 10;
    armor1 = 10;
    attack1 = 8;
    speed1 = 1;
}
if (player1 == GHOSTWARRIOR)
{
    health1 = 20 + 2;
    armor1 = 2;
    attack1 = 2;
    speed1 = 5;
}
if (player1 == OUTWORLDER)
{
    health1 = 15 + 2;
    attack1 = 1;
    armor1 = 2;
    speed1 = 10;
}
if (player1 == MONSTERKNIGHT)
{
    health1 = 15 + 3;
    attack1 = 4;
    armor1 = 3;
    speed1 = 3;
}
if (player1 == DARKGOBLIN)
{
    health1 = 10 + 1;
    attack1 = 8;
    armor1 = 1;
    speed1 = 3;
}


if (player2 == PIRATE)
{
    health2 = 20 + 3;
    attack2 = 3;
    armor2 = 3;
    speed2 = 3;
}
if (player2 == STONECHEWER)
{
    health2 = 50 + 10;
    attack2 = 8;
    armor2 = 10;
    speed2 = 1;
}
if (player2 == GHOSTWARRIOR)
{
    health2 = 20 +2 ;
    attack2 = 2;
    armor2 = 2;
    speed2 = 5;
}
if (player2 == OUTWORLDER)
{
    health2 = 15 + 2;
    attack2 = 1;
    armor2 = 2;
    speed2 = 10;
}
if (player2 == MONSTERKNIGHT)
{
    health2 = 15 + 3;
    attack2 = 4;
    armor2 = 3;
    speed2 = 3;
}
if (player2 == DARKGOBLIN)
{
    health2 = 10 + 1;
    attack2 = 8;
    armor2 = 1;
    speed2 = 3;
}
while (health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2 * Random.Shared.Next (-15,16) / 100d;
    health2 -= attack1 * speed1 * Random.Shared.Next (-15,16) / 100d;
}
if (health1 > 0)
{
    Console.WriteLine("player1 win");
}
else if (health1 < 0)
{
    Console.WriteLine("player1 win");
}
else if (health1 == 0 && health2 == 0)
{
    Console.WriteLine("player1 = player2");
}



















