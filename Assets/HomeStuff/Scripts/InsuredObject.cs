using UnityEngine;
using System.Collections;

public class InsuredObject : MonoBehaviour {

    public enum ObjectType
    {
        Flatscreen = 0,
        Computer,
        Furniture,
        Sports,
        Music,
        Aquarium,
        Clothes,
        Glass
    }
    public enum ObjectDamage
    {
        Fire = 0,
        Water,
        WeakStorm,
        StrongStorm
    }
    public ObjectType Type = ObjectType.Furniture;
    public ObjectDamage? Damage = null;
    public int ValueInEuro = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
