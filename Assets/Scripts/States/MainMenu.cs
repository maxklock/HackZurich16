using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    private StateBehavior _state;

    private void Start()
    {
        _state = GetComponent<StateBehavior>();
    }

    public void StartGame()
    {
        _state.NextBehavior = StateMachine.Instance.InGame;
        _state.CanChangeState = true;
    }
}
