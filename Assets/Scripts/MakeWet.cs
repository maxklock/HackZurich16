using UnityEngine;
using System.Collections;

public class MakeWet : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        Wettable sponge = coll.gameObject.GetComponent<Wettable>();
        if (sponge != null)
        {
            sponge.MakeWet(this);
        }
    }
}
