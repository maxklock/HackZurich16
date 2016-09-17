using UnityEngine;
using System;
using System.Collections;
using HoloToolkit.Unity;

public class InsurancePolicyManager : Singleton<InsurancePolicyManager> {
    public InsuranceName ActiveInsurance;
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

    public int GetInsuredValue(InsuranceName insurance, InsuredObject.ObjectType type, InsuredObject.ObjectDamage? damage)
    {
        if (damage == null)
            return 0;
        return MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)type, (int)damage];
    }

    public int GetInsuredValue(InsuranceName insurance, InsuredObject obj)
    {
        if (obj.Damage == null)
            return 0;
        return MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)obj.Type, (int)obj.Damage];
    }

    public int GetLostValue(InsuranceName insurance, InsuredObject obj)
    {
        if (obj.Damage == null)
            return 0;
        return Mathf.Max(0, obj.ValueInEuro - MaximalInsuredValuePerDamagePerInsurance[(int)insurance, (int)obj.Type, (int)obj.Damage]);
    }

    // Use this for initialization
    void Start () {
        MaximalInsuredValuePerDamagePerInsurance = new int[Enum.GetNames(typeof(InsuranceName)).Length, Enum.GetNames(typeof(InsuredObject.ObjectType)).Length, Enum.GetNames(typeof(InsuredObject.ObjectDamage)).Length];
        ActiveInsurance = InsuranceName.None;
        InitializeInsurances();
    }

    public class InsuranceStatistic
    {
        public InsuranceStatistic()
        {
            InsuredValue = 0;
            LostValue = 0;
            NumBrokenObjects = 0;
        }
        public int InsuredValue;
        public int LostValue;
        public int NumBrokenObjects;
    }

    public InsuranceStatistic GetStatistic(InsuranceName insurance)
    {
        InsuranceStatistic ret = new InsuranceStatistic();
        InsuredObject[] household = UnityEngine.Object.FindObjectsOfType<InsuredObject>();
        foreach(InsuredObject obj in household)
        {
            if(obj.Damage != null)
            {
                ret.InsuredValue += GetInsuredValue(insurance, obj);
                ret.InsuredValue += GetLostValue(insurance, obj);
                ret.NumBrokenObjects++;
            }
        }

        return ret;
    }
	
    private void InitializeInsurances()
    {
        #region None
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.None, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.FireDirt, 0);

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
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.FireDirt, 5000);
                               
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
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.FireDirt, n);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.AxaOptima, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.FireDirt, 1000);
                               
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
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Aquarium,     InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Clothes,      InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Computer,     InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Flatscreen,   InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Furniture,    InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Glass,        InsuredObject.ObjectDamage.FireDirt, 0);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Music,        InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Sports,       InsuredObject.ObjectDamage.FireDirt, m);
        SetValue(InsuranceName.GDV, InsuredObject.ObjectType.Money,        InsuredObject.ObjectDamage.FireDirt, 1500);
                               
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

    public void SetActiveInsurance(string insuranceName)
    {
        bool insuranceWasFound = false;

        foreach(InsuranceName insurance in Enum.GetValues(typeof(InsuranceName)))
        {
            if(insurance.ToString() == insuranceName)
            {
                ActiveInsurance = insurance;
                insuranceWasFound = true;
            }
        }

        if (!insuranceWasFound)
        {
            Debug.LogError("Requested insurance '" + insuranceName + "' does not exist");
            ActiveInsurance = InsuranceName.None;
        }
    }


}
