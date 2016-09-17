using UnityEngine;
using System;
using System.Collections;

public class InsurancePolicyManager : MonoBehaviour {

    public enum InsuranceName
    {
        //Generic = 0,
        AxaOptima = 0,
        AxaBasic,
        GDV,
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
        #region None
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Fire, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.TabWater, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.WeakStorm, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.StrongStorm, 0);

        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Snow, 0);
        #endregion none

        int n = 30000;
                #region Optima
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Fire, 5000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.TabWater, 5000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.WeakStorm, 5000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.StrongStorm, 5000);

        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Snow, 5000);
        #endregion Optima

        #region Basic
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Fire, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Fire, 1000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.TabWater, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.TabWater, 1000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.WeakStorm, 1000);
                               
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.StrongStorm, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.StrongStorm, 1000);

        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Snow, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Snow, 1000);
        #endregion Basic

        int m = 30000;
        #region GDV
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Fire, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Fire, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Fire, 1500);
                               
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.TabWater, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.TabWater, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.TabWater, 1500);

        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.WeakStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.WeakStorm, 0);
                               
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.StrongStorm, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.StrongStorm, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.StrongStorm, 1500);

        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.Snow, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.Snow, 0);
        #endregion GDV

    }

    // Update is called once per frame
    void Update () {
	
	}
}
