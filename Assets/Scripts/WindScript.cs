using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WindScript : MonoBehaviour
{

    public Vector3 Direction;
    public float Speed;

    private List<Rigidbody> _rigidbodies;

	// Use this for initialization
	void Start ()
	{
	    _rigidbodies = FindObjectsOfType<Rigidbody>().ToList();
	}
	
	// Update is called once per frame
	void Update () {
	    _rigidbodies.ForEach(rigid => rigid.AddForce(Direction * Speed));
	}
}
