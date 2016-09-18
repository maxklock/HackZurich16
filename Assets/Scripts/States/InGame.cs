using UnityEngine;
using System.Collections;

using HoloToolkit.Unity;

using UnityEngine.UI;

public class InGame : MonoBehaviour {

    private StateBehavior _state;
    private float _time;

    public Text TimeText;

    private void Start()
    {
        _state = GetComponent<StateBehavior>();
        _time = 60; //2 * 60;

        FindObjectOfType<WindowBehavior>().Weather = (WindowBehavior.WeatherType)Random.Range(0, 3);
    }

    private void Update()
    {
        _time -= Time.deltaTime;

        TimeText.text = ((int)(_time / 60)).ToString("00") + ":" + ((int)(_time % 60)).ToString("00");

        if (_time < 0)
        {
            ExitGame();
        }
    }

    public void ExitGame()
    {
        _state.CanChangeState = true;
    }
}
