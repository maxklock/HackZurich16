using UnityEngine;
using System.Collections;

public class MakeWet : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        Wettable sponge = other.gameObject.GetComponent<Wettable>();
        if (sponge != null)
        {
            sponge.MakeWet(this);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        OnTriggerEnter(coll.collider);
    }
}
