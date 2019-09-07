using UnityEngine;
using System.Collections;
using Tanks.Tank;

public class TankChasingState : TankState
{
    [SerializeField]
    private Color differentColor;

    public override void OnEnterState()
    {
        base.OnEnterState();
        tankView.ChangeColor(differentColor);
    }
}
