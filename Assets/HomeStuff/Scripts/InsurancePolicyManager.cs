using UnityEngine;
using System;
using System.Collections;

public class InsurancePolicyManager : MonoBehaviour {

    public enum InsuranceName
    {
        Generic = 0,
        None
    }
    private int[,,] MaximalInsuredValuePerDamagePerInsurance;
    private void SetValue(InsuranceName insurance, InsuredObject.ObjectType type, InsuredObject.ObjectDamage damage, int value)
    {
        MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)type, (int)damage] = value;
    }

    public int GetInsuredValue(InsuranceName insurance, InsuredObject.ObjectType type, InsuredObject.ObjectDamage damage)
    {
        return MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)type, (int)damage];
    }

    public int GetInsuredValue(InsuranceName insurance, InsuredObject obj)
    {
        return MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)obj.Type, (int)obj.Damage];
    }

    public int GetLostValue(InsuranceName insurance, InsuredObject obj)
    {
        return Mathf.Max(0, obj.ValueInEuro - MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)obj.Type, (int)obj.Damage]);
    }

    // Use this for initialization
    void Start () {
        MaximalInsuredValuePerDamagePerInsurance = new int[Enum.GetNames(typeof(InsuranceName)).Length, Enum.GetNames(typeof(InsuredObject.ObjectType)).Length, Enum.GetNames(typeof(InsuredObject.ObjectDamage)).Length];

        InitializeInsurances();
    }
	
    private void InitializeInsurances()
    {
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Fire, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Water, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Water, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.WeakStorm, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.StrongStorm, 0);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
