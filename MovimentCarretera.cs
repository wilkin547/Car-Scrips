using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentCarretera : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    RectTransform rect;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (GameControllerCar.controllerCar.GetBoolFail())
        {
            rigidbody2D.simulated = false;  
            return;
        }
        rigidbody2D.velocity = GameControllerCar.controllerCar.SpeedGlobalCarretera;
        if (rect.localPosition.y <= -2550)
        {
            rect.position = GameControllerCar.controllerCar.posicionInicialCarretera.position;
        }
    }

}
