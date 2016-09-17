using System.Linq;

using HoloToolkit.Unity;

using UnityEngine;

public class StateMachine : Singleton<StateMachine>
{
    #region member vars

    public StateBehavior CurrentBehavior; 

    #endregion

    #region methods

    // Use this for initialization
    void Start()
    {
        CurrentBehavior = Instantiate(CurrentBehavior);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentBehavior.CanChangeState)
        {
            var tmp = Instantiate(CurrentBehavior.NextBehavior);
            DestroyImmediate(CurrentBehavior.gameObject);

            CurrentBehavior = tmp;
        }
    }

    #endregion
}