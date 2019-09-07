using System;

public class ServiceEvents : Singleton<ServiceEvents>
{
    public event Action OnPlayerDeath;

    public event Action OnGameLoaded;
    public event Action OnGameStarted;

    public event Action<int> OnPurchaseSuccessful;
    public event Action<int> OnPurchaseFailed;
}
