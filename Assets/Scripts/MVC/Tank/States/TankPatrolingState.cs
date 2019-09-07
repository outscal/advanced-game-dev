using UnityEngine;
using System.Collections;
using Tanks.Tank;

public class TankPatrolingState : TankState
{
    private float timeElapsed;

    protected override void Awake()
    {
        base.Awake();
        Debug.Log("Patroling awake");
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        Debug.Log("Entering State: Patroling");
        tankView.ChangeColor(color);
    }

    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Existing State: Patroling");
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > 5f)
        {
            tankView.ChangeState(tankView.chasingState);
        }
    }
}
