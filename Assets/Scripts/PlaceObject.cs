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
        if (col.gameObject.GetComponent<InteractiveObject>() == null)
        {
            return;
        }
        _canCollide = false;
    }

    public void OnCollisionStay(Collision col)
    {
        var interaction = col.gameObject.GetComponent<InteractiveObject>();
        if (_tapToPlace.Placing || !_canCollide || interaction == null)
        {
            return;
        }

        interaction.Action.Invoke();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (!_tapToPlace.Placing || col.gameObject.GetComponent<InteractiveObject>() == null)
        {
            return;
        }
        _canCollide = true;
    }
}
