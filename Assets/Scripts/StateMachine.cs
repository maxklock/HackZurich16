using System.Linq;

using HoloToolkit.Unity;

using UnityEngine;

public class StateMachine : Singleton<StateMachine>
{
    #region member vars

    public StateBehavior CurrentBehavior;

    [Space]
    public StateBehavior MainMenu;

    public StateBehavior InGame;

    #endregion

    #region methods

    // Use this for initialization
    void Start()
    {
        MainMenu.gameObject.SetActive(false);
        InGame.gameObject.SetActive(false);

        CurrentBehavior.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentBehavior.CanChangeState)
        {
            CurrentBehavior.gameObject.SetActive(false);
            CurrentBehavior.CanChangeState = false;

            CurrentBehavior = CurrentBehavior.NextBehavior;
            CurrentBehavior.gameObject.SetActive(true);
        }
    }

    #endregion
}