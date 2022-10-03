using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float _movementSpeed;
    public float _rotationSpeed;
    public TankType tankType;
    public Material tankColor;
    

    public TankModel(float _movement, float _rotation, TankType _tanktype, Material _color)
    {
        _rotationSpeed = _rotation;
        _movementSpeed = _movement;
        tankType = _tanktype;
        tankColor = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
