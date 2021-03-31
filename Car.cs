using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Car : MonoBehaviour
{
    private Rigidbody2D This_rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        This_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CarGameController.carGameController.Fail)
        {
            This_rigidbody2D.simulated = false;
        }

        if (transform.position.y < -6.30)
        {
            transform.position = CarGameController.carGameController.GetRamdomPosition();
            CarGameController.carGameController.UpdateScore();
        }

        This_rigidbody2D.velocity = new Vector2(0, -CarGameController.carGameController.Speed);
    }
}
