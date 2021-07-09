using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollScript : MonoBehaviour
{
    public GameObject chestie1;
    public GameObject chestie2;
    public GameObject chestie3;
    public GameObject chestie4;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(chestie1.GetComponent<Collider2D>(), chestie2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(chestie3.GetComponent<Collider2D>(), chestie4.GetComponent<Collider2D>());
    }
}
