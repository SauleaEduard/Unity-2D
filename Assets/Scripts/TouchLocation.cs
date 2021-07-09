using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchLocation : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    public TextMeshProUGUI locatie;

    void Update()
    {
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
        locatie.text = mouseWorldPosition.ToString();
    }
}
