using UnityEngine;
using System.Collections;

using HoloToolkit.Unity;

using UnityEngine.Events;

public class PlaceObject : MonoBehaviour
{
    private TapToPlace _tapToPlace;
    private bool _canCollide;

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

    public void OnCollisionExit(Collision col)
    {
        var tap = col.gameObject.GetComponent<TapToPlace>();
        if (tap == null)
        {
            return;
        }
        _canCollide = false;
    }

    public void OnCollisionStay(Collision col)
    {
        var tap = col.gameObject.GetComponent<TapToPlace>();
        if (tap == null || !_canCollide)
        {
            return;
        }

        if (!_tapToPlace.Placing)
        {
            var interaction = col.gameObject.GetComponent<InteractiveObject>();
            interaction.Action.Invoke();
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        var tap = col.gameObject.GetComponent<TapToPlace>();
        if (tap == null || !_tapToPlace.Placing)
        {
            return;
        }
        _canCollide = true;
    }
}
