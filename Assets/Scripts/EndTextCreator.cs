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
        InsurancePolicyManager.InsuranceName activeInsurance = InsurancePolicyManager.Instance.ActiveInsurance;
        InsurancePolicyManager.InsuranceStatistic statistic = InsurancePolicyManager.Instance.GetStatistic(activeInsurance);

        var time = string.Empty;
        if (InGame.GameDuration > 60)
        {
            time = ((int)(InGame.GameDuration / 60)).ToString("00") + ":" + ((int)(InGame.GameDuration % 60)).ToString("00") + " Minutes";
        }
        else
        {
            time = ((int)InGame.GameDuration).ToString("0") + " Seconds";
        }

        //report total damage
        string endText = "In " + time + " you caused a total damage of"
            + "\n" + (statistic.LostValue + statistic.InsuredValue) + "€ (" + statistic.NumBrokenObjects + " broken Objects)";
        //data on your insurance
        if (activeInsurance != InsurancePolicyManager.InsuranceName.None)
            endText += "\n"
                + "\nYour insurance (" + activeInsurance.ToString() + ") covers"
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
