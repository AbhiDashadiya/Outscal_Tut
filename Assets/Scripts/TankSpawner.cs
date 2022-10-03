using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] public TankView tankView;
    
    public List<Tank> tanks = new List<Tank>();

    public int tankNumber;

    void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tanks[tankNumber].movementSpeed, tanks[tankNumber].rotationSpeed, tanks[tankNumber].tankType, tanks[tankNumber].color);
        TankController tankController = new TankController(tankModel, tankView);
    }

    
}

[System.Serializable]
public class Tank
{
    public float movementSpeed;
    public float rotationSpeed;
    public TankType tankType;
    public Material color;
}