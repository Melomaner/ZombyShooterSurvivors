using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool doDamage = true;
    public float health = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(float damage)
    {
        health -= damage;
        Debug.Log("Осталось - " + health + " HP");
        if (health <= 0)
        {
            Dead();
        }
    }
    public void Dead()
    {
        Destroy(this.gameObject);   
    }
}
