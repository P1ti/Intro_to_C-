using UnityEngine;

public class Health : MonoBehaviour
{
    int health = 1;

    void reduceHealth(int amount)
    {
        health = health - amount;
    }

    //Building constractor
    public Health()
    {
        health = 10;
    }

    //Specific constractor
    public Health(int myHealth)
    {
        health = myHealth;
    }
}