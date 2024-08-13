Random random = new Random();

// hero and monster initial health
int hero = 10;
int monster = 10;


do
{
    int attack = random.Next(1, 11);
    monster = monster - attack;

    //The hero attacks first.
    /*Print the amount of health the monster lost and their remaining health.*/
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

    //If the monster's health is greater than 0, it can attack the hero.
    if (monster > 0)
    {
        attack = random.Next(1, 11);
        hero = hero - attack;
        //Print the amount of health the hero lost and their remaining health.
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
    }


    //Continue this sequence of attacking until either the monster's health or hero's health is zero or less

} while (monster > 0 && hero > 0);

//Print the winner.
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");








