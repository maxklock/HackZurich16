using UnityEngine;
using System.Collections;

public class GlassBreaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStart(Collision coll)
    {
        Breakable glass = coll.gameObject.GetComponent<Breakable>();
        if (glass != null)
        {
            glass.Break(this);
        }
    }
}
