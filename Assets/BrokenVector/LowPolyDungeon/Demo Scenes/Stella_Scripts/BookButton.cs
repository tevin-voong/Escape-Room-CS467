using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BookButton : MonoBehaviour
{

    public GameObject book;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // nothing
    }

    // Update is called once per frame
    void Update()
    {

        // debug messages on where clicks are happening
        if (Input.GetMouseButtonDown(0))
        {
            if (book == getClickedObject(out RaycastHit hit))
            {

                Debug.Log("Clicked book");

            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Not clicked");
        }

    }

    // create the get clicked object
    GameObject getClickedObject (out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Physics.Raycast (ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject())
            {
                target = hit.collider.gameObject;
            }
        }
        return target;
    }

    //detects where the click is occurring on screen
    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(ped,results);
        return results.Count > 0;

    }
}
