using UnityEngine;
using System.Collections;

public class Factory
{
    public Factory()
    {

    }
    public static GenericPlayer InstancePlayer(int opt)
    {
        GameObject character;
        switch(opt)
        {
            case 1:
                character = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Warrior", typeof(GameObject))) as GameObject;
                character.name = "Warrior";
                return character.AddComponent<PlayerWarrior>();
            case 2:
                character = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Archer", typeof(GameObject))) as GameObject;
                character.name = "Archer";
                return character.AddComponent<PlayerArcher>();
            case 3:
                character = GameObject.Instantiate(Resources.Load("Prefabs/Characters/Wizzard", typeof(GameObject))) as GameObject;
                character.name = "Wizzard";
                return character.AddComponent<PlayerWizzard>();
            default:
                return null;
        }
    }

    public static GameObject FindProjectile(int opt)
    {
        GameObject projectile;
        switch (opt)
        {
            case 1:
                projectile = Resources.Load("Prefabs/Projectiles/ProjectileSword", typeof(GameObject)) as GameObject;
                return projectile;
            case 2:
                projectile = Resources.Load("Prefabs/Projectiles/ProjectileArrow", typeof(GameObject)) as GameObject;
                return projectile;
            case 3:
                projectile = Resources.Load("Prefabs/Projectiles/ProjectileOrb", typeof(GameObject)) as GameObject;
                return projectile;
            default:
                return null;
        }
    }
}
