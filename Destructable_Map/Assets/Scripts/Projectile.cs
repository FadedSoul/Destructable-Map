using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    [SerializeField]
    private float travelLimit;

    [SerializeField]
    private CircleCollider2D blastRadius;

    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("help");

        //checks if its the object we want to hit
        if (coll.gameObject.tag == "Target")
        {
            coll.gameObject.GetComponent<GroundController>().DestroyGround(blastRadius);
            Destroy(gameObject);
        }
    }

    void Update() {

        //makes sure the object is deleted when out of field
        if (this.transform.position.y < travelLimit)
        {
            Destroy(gameObject);
        }
    }
}
