using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float speed = 20.0f;
    static float a = 0.2f;
    public int maxspeed = 700;
    int flag=1;

    void Update()
    {
        if(speed<maxspeed)
        speed = speed + a;
        //Debug.Log("s | a: " + speed + " " + a);
        transform.Rotate(0,0,speed * Time.deltaTime);
        if (speed>flag*100 && gameObject.name=="obstacol2")
        {
            flag++;
            int i = Random.Range(0, 2);
            GameObject.Find("Spawner").GetComponent<Spawner>().spawnSomething(i);
        }
    }
}