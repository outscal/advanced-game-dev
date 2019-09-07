using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks.Tank
{
    public class TankController
    {
        public TankController(TankModel tankModel, TankView tankPrefab)
        {
            TankModel = tankModel;
            TankView = Object.Instantiate(tankPrefab);
            TankView.Initalise(this);
            Debug.Log("tank view created", TankView);
        }

        public void ApplyDamage(BulletType bulletType, int damage)
        {
            // 
            if(TankModel.Health - damage <= 0)
            {
                // death event 
            } 
            else
            {
                TankModel.Health -= damage;
                Debug.Log("Player took damage: " + TankModel.Health);
            }
        }

        public void Disable()
        {
            TankView.Disable();
        }

        public void Enable()
        {
            TankView.Enable();
        }

        public TankModel TankModel { get; }
        public TankView TankView { get; }
    }
}