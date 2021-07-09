using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    static float speedz = 15.0f;
    static float speedy = 1f;
    public int finish = 0;

    void Update()
    {
        float oz = gameObject.transform.rotation.eulerAngles.z;
        float oy = gameObject.transform.position.y;
        if ((oz >= 75 && oz <=180 && speedz>0) || (oz<=280 && oz>=180 && speedz<0))
            speedz *= -1;
        gameObject.transform.Rotate(0, 0, speedz * Time.deltaTime);
        if ((oy >= 4.0f && speedy > 0) || (oy <= -4.0f && speedy < 0))
        {
            speedy *= -1;
        }
        gameObject.transform.position = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y+speedy*Time.deltaTime);
    }
}
