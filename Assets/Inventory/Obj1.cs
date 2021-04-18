using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj1 : MonoBehaviour, IInventoryItem
{
    // Start is called before the first frame update
    public string Name
    {
        get
        {
            return "obj1";
        }
    }

    public Sprite _Image;
    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }
}
