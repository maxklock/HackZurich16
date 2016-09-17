using UnityEngine;
using System.Collections;

using HoloToolkit.Unity;

using UnityEngine.Events;

public class PlaceObject : MonoBehaviour
{
    private TapToPlace _tapToPlace;

	// Use this for initialization
    void Start()
    {
        _tapToPlace = GetComponent<TapToPlace>();
    }

    // Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        _tapToPlace.PerformSelect();
	    }
	}

    public void OnCollisionEnter(Collision col)
    {
        
    }
}
