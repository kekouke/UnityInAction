using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    void Start()
    {
        _health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health: " + _health);
    }
}
