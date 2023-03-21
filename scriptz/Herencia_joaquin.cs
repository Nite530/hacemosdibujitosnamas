using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : baseclass
{
    private string _name;
    private int _life;
    private int _rage;

    public warrior(string name, int life, int rage) : base(name, life)
    {
        _rage = rage;
    }

    public void Charge()
    {
        Debug.Log("carga");
    }

    public override void BasicAttack()
    {
        base.BasicAttack();
        Debug.Log("empujo");
    } 
}
