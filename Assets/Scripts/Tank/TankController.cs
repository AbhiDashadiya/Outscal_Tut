using System;
using UnityEditor;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;

    public Rigidbody tankRigidBody;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        tankRigidBody = tankView.GetRigidBody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }

    public void MoveTank(float _movement, float _movementSpeed)
    {
        tankRigidBody.velocity = tankView.transform.forward * _movement * _movementSpeed;
    }

    public void RotateTank(float _rotate, float _rotationSpeed)
    {
        Vector3 vector = new Vector3(0f,_rotate * _rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        tankRigidBody.MoveRotation(tankRigidBody.rotation * deltaRotation);
    }

    
    //Refrence for TankView for Variables 
    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
