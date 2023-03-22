using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseclass : MonoBehaviour
{
    private string _name;
    private int _life;

    public baseclass(string name, int life)
    {
        _name = name;
        _life = life;
    }

    public virtual void BasicAttack()
    {
        Debug.Log("ataco");
    }
}
