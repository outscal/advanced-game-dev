using System;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableOject", menuName = "ScriptableObjects/NewTankScriptableObject")]
public class TankScriptableObject: ScriptableObject
{
    public TankType TankType;
    public string TankName;
    public float Speed;
    public float Health;
    public BulletType BulletType;
    public TankView TankView;
}



[CreateAssetMenu(fileName = "TankScriptableOjectList", menuName = "ScriptableObjects/NewTankListScriptableObject")]
public class TankScriptableObjectList : ScriptableObject
{
    public TankScriptableObject[] tanks;
}
