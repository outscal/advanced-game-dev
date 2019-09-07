using UnityEngine;
using System.Collections;

namespace Tanks.Tank
{
    [RequireComponent(typeof(TankView))]
    public class TankState : MonoBehaviour
    {
        protected TankView tankView;

        [SerializeField]
        protected Color color;

        protected virtual void Awake()
        {
            tankView = GetComponent<TankView>();
        }

        public virtual void OnEnterState() {
            this.enabled = true;
        }

        public virtual void OnExitState() {
            this.enabled = false;
            // cleaning up
        }

        //public virtual void Tick() {} // update 
    }
}
