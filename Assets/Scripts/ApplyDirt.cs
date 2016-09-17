using UnityEngine;
using System.Collections;

public class ApplyDirt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        BecomeDirty fuel = coll.gameObject.GetComponent<BecomeDirty>();
        if (fuel != null)
        {
            fuel.ApplyDirt(this);
        }
    }
}
