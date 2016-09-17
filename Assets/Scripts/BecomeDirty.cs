using UnityEngine;
using System.Collections;

[RequireComponent(typeof(InsuredObject))]
public class BecomeDirty : MonoBehaviour {
    public Texture DirtyTexture; 
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ApplyDirt(ApplyDirt dirt)
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if(rend != null)
        {
            rend.material.mainTexture = DirtyTexture;
        }
        GetComponent<InsuredObject>().SetDamage(InsuredObject.ObjectDamage.FireDirt);
    }
}
