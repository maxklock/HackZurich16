using UnityEngine;
using System.Collections;

public class InsuredObject : MonoBehaviour
{

    public enum ObjectType
    {
        Flatscreen = 0,
        Computer,
        Furniture,
        Sports,
        Music,
        Aquarium,
        Clothes,
        Glass,
        //Professional,
        Money
    }
    public enum ObjectDamage
    {
        FireDirt = 0,
        TabWater,
        WeakStorm,
        StrongStorm,
        Snow
    }
    public ObjectType Type = ObjectType.Furniture;
    public ObjectDamage? Damage = null;
    public int ValueInEuro = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDamage(ObjectDamage damage)
    {
        InsurancePolicyManager insure = InsurancePolicyManager.Instance;
        if (insure.GetInsuredValue(insure.ActiveInsurance, this.Type, damage) > insure.GetInsuredValue(insure.ActiveInsurance, this))
        {
            this.Damage = damage;
        }
    }
}
