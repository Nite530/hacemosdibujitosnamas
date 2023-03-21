using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practices : MonoBehaviour
{
    warrior mywarrior;
    baseclass mybaseclass;

    private void Start()
    {
        mybaseclass = new baseclass("pepes", 100);
        mywarrior = new warrior("pepe",100,150);
        mywarrior.BasicAttack();
    }

    private void Update()
    {

    }
}
