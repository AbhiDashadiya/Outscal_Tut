using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float _movementSpeed;
    public float _rotationSpeed;

    public TankModel(float _movement, float _rotation)
    {
        _rotationSpeed = _rotation;
        _movementSpeed = _movement;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
