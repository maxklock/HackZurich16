using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    private StateBehavior _state;

    public StateBehavior InGame;

    private void Start()
    {
        _state = GetComponent<StateBehavior>();
    }

    public void StartGame()
    {
        _state.NextBehavior = InGame;
        _state.CanChangeState = true;
    }
}
