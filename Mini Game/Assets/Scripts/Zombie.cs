using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody _zombieRb;
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _zombieRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookdirection = (_player.transform.position - transform.position).normalized;
        _zombieRb.AddForce(lookdirection * speed);
    }
}
