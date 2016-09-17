using UnityEngine;
using System.Collections;

public class WindowBehavior : MonoBehaviour {

    public enum WeatherType
    {
        Snow,
        LightStorm,
        HeavyStorm
    }

    public WeatherType Weather;

    private WeatherType _currentWeather;

    public GameObject SnowWindow;
    public GameObject LightStormWindow;
    public GameObject HeavyStormWindow;

	// Use this for initialization
	void Start ()
	{
	    _currentWeather = Weather;
        ChangeWeather();
	}

    private void ChangeWeather()
    {
        SnowWindow.SetActive(Weather == WeatherType.Snow);
        LightStormWindow.SetActive(Weather == WeatherType.LightStorm);
        HeavyStormWindow.SetActive(Weather == WeatherType.HeavyStorm);
    }
	
	// Update is called once per frame
	void Update () {
	    if (_currentWeather != Weather)
	    {
	        ChangeWeather();
	    }
	    _currentWeather = Weather;
	}
}
