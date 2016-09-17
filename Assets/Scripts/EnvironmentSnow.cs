using UnityEngine;
using System.Collections;

public class EnvironmentSnow : MonoBehaviour {
    public bool Active;

	// Use this for initialization
	void Start () {
        Active = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelected()
    {
        Animator controll = GetComponent<Animator>();
        if(controll != null)
        {
            if (!Active)
            {
                controll.Play("Move");
                Active = true;
                //Start a Storm
            }
        }
    }
    
}
