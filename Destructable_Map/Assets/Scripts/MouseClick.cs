using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour
{
    [SerializeField]
    private GameObject SpawnObject;
    // Update is called once per frame
    void Update()
    {
        //checks for input and spawns het object op mouse position
        if (Input.GetButtonDown("Fire1"))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 1.0f;       //zorgt ervoor dat het object niet achter andere spawned
            var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(SpawnObject, objectPos, Quaternion.identity);
        }
    }
}