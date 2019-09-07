using System.Collections;
using System.Collections.Generic;
using Tanks.Tank;
using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView tankView;
    public GameObject wrongTankView;

    private ServicePoolTank servicePoolTank;

    //public TankScriptableObject[] tankConfigurations;
    public TankScriptableObjectList tankList;

    private void Start()
    {
        servicePoolTank = GetComponent<ServicePoolTank>();
        StartGame();
    }

    public void StartGame()
    {
        for (int i = 0; i < 5; i++)
        {
            TankController tankController = CreateNewTank(i);
            StartCoroutine(ReturnTank(tankController));
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TankController tankController = CreateNewTank(0);
            StartCoroutine(ReturnTank(tankController));
        }
    }

    IEnumerator ReturnTank(TankController tankController)
    {
        yield return new WaitForSeconds(5f);
        tankController.Disable();
        servicePoolTank.ReturnItem(tankController);
    }


    private TankController CreateNewTank(int index)
    {
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        Debug.Log("Creating Tank with type: " + tankScriptableObject.TankName);

        TankModel model = new TankModel(tankScriptableObject);
        //TankController tank = new TankController(model, tankView);
        TankController tank = servicePoolTank.GetTank(model, tankView);
        tank.Enable();
        return tank;
    }
}
