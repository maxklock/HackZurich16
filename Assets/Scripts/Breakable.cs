using UnityEngine;
using System.Collections;

[RequireComponent(typeof(InsuredObject))]
public class Breakable : MonoBehaviour {
    public Texture BrokenTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Break(GlassBreaker breaker)
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.mainTexture = BrokenTexture;
        }
    }
}
