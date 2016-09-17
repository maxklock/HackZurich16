using UnityEngine;
using System.Collections;

public class SetFire : MonoBehaviour {
    public ParticleSystem Fire;

    // Use this for initialization
    void Start () {
        Fire.Pause();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStart(Collision coll)
    {
        BeFired fuel = coll.gameObject.GetComponent<BeFired>();
        if (fuel != null)
        {
            fuel.SetOnFire(this);
        }
        if(Fire != null)
            Fire.Play();
    }
}
