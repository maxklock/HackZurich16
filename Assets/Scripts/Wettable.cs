using UnityEngine;
using System.Collections;

[RequireComponent(typeof(InsuredObject))]
public class Wettable : MonoBehaviour {
    public ParticleSystem Drops;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void MakeWet(MakeWet water)
    {
        Drops.gameObject.SetActive(true);
        gameObject.GetComponent<InsuredObject>().SetDamage(InsuredObject.ObjectDamage.TabWater);
    }
}
