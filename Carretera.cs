using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Carretera : MonoBehaviour
{

    public float SpeedY = -20;
    public float SpeedX = 0;
    private Rigidbody2D ThisRigidbody2D;
    public float limite;

    private void Start()
    {
        ThisRigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (CarGameController.carGameController.Fail) ThisRigidbody2D.simulated = false;

        ThisRigidbody2D.velocity = new Vector2(SpeedX, SpeedY);

        if (transform.position.y <= limite)
        {
            transform.position = new Vector2(transform.position.x, 13.4f);
        }

    }
}
