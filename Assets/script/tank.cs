using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float Speed;
    public float timerDespawn;
    void Start()
    {
        StartCoroutine("despawn");
    }

    IEnumerator despawn()
    {
        yield return new WaitForSecondsRealtime(timerDespawn);
        gameObject.SetActive(false);
    }
    void Update()
    {
        rigidbody.velocity = new Vector2(Speed, rigidbody.velocity.y);
    }
}
