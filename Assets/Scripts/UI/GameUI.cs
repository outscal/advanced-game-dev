using UnityEngine;
using System.Collections;
using System;

public class GameUI : MonoBehaviour
{
    public event Action OnDeath;

    public event Action<int, int> onDeath;

    void Start()
    {
        OnDeath += GameUI_OnDeath;
        onDeath += GameUI_onDeath;

        //OnDeath.Invoke();
        OnDeath?.Invoke();

        onDeath?.Invoke(0, 100);
    }

    private void GameUI_onDeath(int idTankDead, int idTankKilled)
    {
    }

    private void GameUI_OnDeath()
    {
        throw new NotImplementedException();
    }

    private void OnDestroy()
    {
        OnDeath -= GameUI_OnDeath;
        onDeath -= GameUI_onDeath;
    }
}
