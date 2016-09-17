using UnityEngine;
using System.Collections;

public class SetFire : MonoBehaviour
{
    // not necessary, but in case we want to let it BURN(!) it can become useful
    public ParticleSystem Fire = null;
    
    void Start ()
    {
        if (Fire != null)
            Fire.Pause();
    }
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
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
