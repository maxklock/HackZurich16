using UnityEngine;
using System.Collections;

public class InGame : MonoBehaviour {

    private StateBehavior _state;

    private void Start()
    {
        _state = GetComponent<StateBehavior>();
    }

    public void ExitGame()
    {
        _state.CanChangeState = true;
    }
}
