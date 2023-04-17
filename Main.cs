using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;

        if (health <20)
        {
            Debug.Log("Health low!");
        } else if (health > 80)
        {
            Debug.Log("Health high!");
        } else
        {
            Debug.Log("Health OK!");
        }

        int score = 10;

        if ((health > 80) && (score > 5))
        {
            Debug.Log("Hello");
        } else
        {
            Debug.Log("Come back later");
        }

        bool levelUp;
        if (score>100)
        {
            levelUp = true;
        } else
        {
            levelUp = false;
            Debug.Log("Come back, when you will have a higher score!");
        }

        bool alive;
        if (health>0)
        {
            alive = true;
        } else
        {
            alive = false;
        }


        /* Containers */
        int[] values = new int[10]; // same declaration for container like in Java
        values[0] = 10;
        values[9] = 1;

        int length = values.Length; // to find out the size of an array, the method is like in Java, but there the length is written with upper l (values.Length not values.length)
        List<int> ages = new List<int>() { 1, 2, 3, 4, 5 };

        ages.Add(6); // adds the value 6
        ages.Remove(1); 
        ages.Insert(0, 2); // insert the value 2 on 0 position
        int listLength = ages.Count; // this is the way we find the length of a list

        string[] names = { "Lili", "John", "Michael", "Marius" };
        foreach (string name in names)
        {
            Debug.Log(name);
        }

        string nume = "Mihai";
        int nameLength = nume.Length; // this is how I find the size of a string

        //int plateNumber = 20;
        //string plateNumberS = plateNumber.toString();

        //Dictionary<string, string> name = new Dictionary<string, string>();
        //name.Add("place", "castle");
        //name.Add("car", "bmw");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
