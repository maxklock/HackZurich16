using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    private StateBehavior _state;

    private void Start()
    {
        _state = GetComponent<StateBehavior>();
    }

    public void StartGame(string insuranceName)
    { 
        _state.CanChangeState = true;
        FindObjectOfType<InsurancePolicyManager>().SetActiveInsurance(insuranceName);
    }
}
