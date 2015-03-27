using UnityEngine;
using System.Collections;

public class Factory
{
    public Factory()
    {

    }
    public static GenericPlayer InstancePlayer(int opt)
    {
        GameObject chararcters;
        switch(opt)
        {
            case 1:
                chararcters = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Warrior", typeof(GameObject))) as GameObject;
                chararcters.name = "Warrior";
                return chararcters.AddComponent<PlayerWarrior>();
            case 2:
                chararcters = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Archer", typeof(GameObject))) as GameObject;
                chararcters.name = "Archer";
                return chararcters.AddComponent<PlayerArcher>();
            case 3:
                chararcters = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Wizzard", typeof(GameObject))) as GameObject;
                chararcters.name = "Wizzard";
                return chararcters.AddComponent<PlayerWizzard>();
            default:
                return null;
        }
    }

    public static GenericProjectile InstanceEffect(int opt)
    {
        switch (opt)
        {
            case 1:
                return null;
            case 2:
                return null;
            case 3:
                return null;
            default:
                return null;
        }
    }
}
