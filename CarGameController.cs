using UnityEngine;
public class CarGameController : PadreGameController
{
    public static  CarGameController carGameController;
    [SerializeField]
    private Transform[] PositiosRespanw;
    // Start is called before the first frame update
    void Start()
    {
        CarGameController.carGameController = this;
    }

    public Vector3 GetRamdomPosition()
    {
        return PositiosRespanw[Random.Range(0, 2)].position;
    }

}
