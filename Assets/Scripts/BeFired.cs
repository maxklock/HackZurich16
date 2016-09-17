using UnityEngine;
using System.Collections;

[RequireComponent(typeof(InsuredObject))]
public class BeFired : MonoBehaviour {
    public ParticleSystem Fire;
    
	// Use this for initialization
	void Start () {
        Fire.Pause();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //void OnCollisionStart(Collision coll)
    //{
    //    //if(coll.gameObject.GetComponent<>)
    //}

    public void SetOnFire(SetFire fire)
    {
        Fire.Play();
        gameObject.GetComponent<InsuredObject>().SetDamage(InsuredObject.ObjectDamage.FireDirt);
    }
}
