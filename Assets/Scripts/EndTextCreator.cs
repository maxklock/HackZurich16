using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndTextCreator : MonoBehaviour
{

    public Text text;

	// Use this for initialization
	void Start ()
    {
	
	}

    void OnEnable()
    {
        GenerateEndText();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void GenerateEndText()
    {
        InsurancePolicyManager.InsuranceStatistic statistic = InsurancePolicyManager.Instance.GetStatistic(InsurancePolicyManager.Instance.ActiveInsurance);

        //report total damage
        string endText = "In 2 Minutes you caused a total damage of"
            + "\n" + statistic.LostValue + statistic.InsuredValue + "€ (" + statistic.NumBrokenObjects + " broken Objects)";
        //data on your insurance
        if (InsurancePolicyManager.Instance.ActiveInsurance != InsurancePolicyManager.InsuranceName.None)
            endText += "\n"
                + "\nYour insurance (" + InsurancePolicyManager.Instance.ActiveInsurance.ToString() + ") covers"
                + "\n" + statistic.InsuredValue + "€";
        else
        {
            if(statistic.LostValue > 1000){
                endText += "\n"
                    + "\nMaybe you should have gotten an insurance...";
            }
        }

        text.text = endText;
    }
}
