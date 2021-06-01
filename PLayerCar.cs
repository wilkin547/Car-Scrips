using UnityEngine;

public class PLayerCar : MonoBehaviour
{
    private RectTransform Rtransform;
    private Touch mitouche;


    /// <summary>
    /// lleva de 0 a 2 para mover el carro 
    /// </summary>
    byte i = 0;
    public RectTransform[] posiciones = new RectTransform[3];

    private void Start()
    {
        Rtransform = GetComponent<RectTransform>();
    }


    float pocicionInicial;
    float pocicionfinal;
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            mitouche = Input.GetTouch(0);

            switch (mitouche.phase)
            {
                case TouchPhase.Began:
                    pocicionInicial = mitouche.position.x;
                    break;

                case TouchPhase.Ended:
                    pocicionfinal = mitouche.position.x;

                    if (pocicionInicial < pocicionfinal)
                    {
                        if (i <= 2)
                        {
                            i++;
                        }
                        if(i >= 2)
                        {
                            i = 2;
                        }

                    }
                    else
                    {
                        if (i >= 0)
                        {
                            i--;
                        }

                            
                        
                    }

                    break;

            }
                        if (i <= 0)
                        {
                            i = 0;
                        } 
            Rtransform.position = posiciones[i].position;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameControllerCar.controllerCar.GameOver();
    }


}
