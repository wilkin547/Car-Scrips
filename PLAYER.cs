using UnityEngine;


[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PLAYER : MonoBehaviour
{
    [SerializeField]
    private GameObject choque;
    private Vector2 vector2;
    private Rigidbody2D mj_Rb;
    [Space]
    [SerializeField]
    private float limiteEnX;
    [SerializeField]
    private float limiteEnY;
    private Touch touch;

    private void Start()
    {
        mj_Rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        //to move the play while is touching
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            vector2 = Camera.main.ScreenToWorldPoint(touch.position);
        }

        if (CarGameController.carGameController.Fail)
        {
            mj_Rb.simulated = false;
        }

        transform.position = vector2;

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -limiteEnX, limiteEnX), Mathf.Clamp(transform.position.y, -limiteEnY, limiteEnY));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CarGameController.carGameController.GameOver();
        choque.SetActive(true);
    }



}
