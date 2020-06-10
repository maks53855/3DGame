using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    public Transform monster;
    public Transform point;
    public int speed;

    void Update()
    {
        transform.position = Vector3.Lerp(monster.position, point.position, speed);
    }
}