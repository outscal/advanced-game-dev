using System;
using System.Collections;
using System.Collections.Generic;
using Tanks.Tank;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TankView : MonoBehaviour, IDamagable
{
    public TankType tankType;

    private TankController tankController;
    private Image image;

    private TankState currentState;

    [SerializeField]
    public TankPatrolingState patrolingState;
    [SerializeField]
    public TankChasingState chasingState;


    [SerializeField]
    private TankState startingState;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        //ChangeState(startingState);
        ChangeState(patrolingState);
    }

    public void TakeDamage(BulletType bulletType, int damage)
    {
        Debug.Log("Taking damage: " + damage + "from bullet: "+ bulletType);
        tankController.ApplyDamage(bulletType, damage);
    }

    internal void Enable()
    {
        gameObject.SetActive(true);
    }

    internal void Disable()
    {
        gameObject.SetActive(false);
    }

    public void Initalise(TankController tankController)
    {
        this.tankController = tankController;
    }

    public void ChangeColor(Color color)
    {
        image.color = color;
    }

    public void ChangeState(TankState newState)
    {
        if(currentState != null)
        {
            currentState.OnExitState();
        }

        currentState = newState;

        currentState.OnEnterState();
    }
}
