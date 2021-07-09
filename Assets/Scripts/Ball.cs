using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    GameObject destroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().pornit)
        {
            int p;
            if (gameObject.name.Contains("Plaja"))
            {
                p = 2;
                Debug.Log("s-a distrus o minge de plaja");
            }
            else if (gameObject.name.Contains("Basket"))
            {
                p = 3;
                Debug.Log("S-a distrus o minge de Basket");
            }
            else
            {
                p = 12;
                Debug.Log("S-a distrus o minge de fotbal");
            }
            Instantiate(destroy, transform.position, destroy.transform.rotation);
            DestroyImmediate(gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().ScoreAdd(p);
            GameObject.Find("GameManager").GetComponent<GameManager>().VerificaWin();
        }
    }
}
