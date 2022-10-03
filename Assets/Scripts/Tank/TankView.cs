using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    [SerializeField]private Rigidbody rb;

    private float _movement;
    private float _rotation;

    public MeshRenderer[] child;

    // Start is called before the first frame update
    void Start()
    {
        // Camera SetUp Script
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        tankMovement();

        if(_movement != 0)
        {
            tankController.MoveTank(_movement, tankController.GetTankModel()._movementSpeed);
        }

        if(_rotation != 0)
        {
            tankController.RotateTank(_rotation, tankController.GetTankModel()._rotationSpeed);
        }

        
    }

    private void tankMovement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    public void changeColor(Material _color)
    {
        foreach(var i in child)
        {
            i.material = _color;
        }
    }
}