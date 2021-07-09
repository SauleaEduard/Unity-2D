using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log( gameObject.name+" collided with "+ collision.gameObject.name);
    }
}
