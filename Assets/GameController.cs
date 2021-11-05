using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform glass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.touchCount > 0)
        {
            glass.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            glass.position = new Vector3(glass.position.x, glass.position.y, 0.0f);
        }*/
    }

/*    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1 * (Camera.main.transform.position.z));
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        glass.position = objPosition;
    }*/
}
