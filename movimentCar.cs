using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <inheritdoc/>
/// </summary>
public class movimentCar : Moviment
{
    protected override void Setvelocity()
    {
        if (GameControllerCar.controllerCar.GetBoolFail())
        {
            rigidbody2D.simulated = false;
            return;
        }
        rigidbody2D.velocity = GameControllerCar.controllerCar.SetVelocity();
    }

    protected override void ReStar()
    {
        rectTransform.position = GameControllerCar.controllerCar.GetRectTransformRamdon();
        GameControllerCar.controllerCar.UpdateScore();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Finish"))
        {
        base.OnCollisionEnter2D(collision);

        }
    }
}
