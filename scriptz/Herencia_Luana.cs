using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herencia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy1 = new Enemy();

        enemy1.vida = 5;

        enemy1.MeleeAttack();
        
        FlyingEnemy flyingEnemy1 = new FlyingEnemy();

        flyingEnemy1.vida = 5;

        flyingEnemy1.FlyingAttack();
    }

    
}

class Enemy
{
    public int vida;

    public float ataque;

    public string nombre;

    public void MeleeAttack()
    {
        Debug.Log("MeleeAttack");
    }
}


class FlyingEnemy: Enemy
{
    public void FlyingAttack()
    {
        Debug.Log("FlyAttack");
    }
}
