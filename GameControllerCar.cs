using UnityEngine;

public class GameControllerCar : gameControllerPadre
{
    public static GameControllerCar controllerCar;
    /// <summary>
    /// the speed of the carretera 
    /// </summary>
    public Vector2 SpeedGlobalCarretera;
    public RectTransform posicionInicialCarretera;
    public RectTransform[] RamdomPosition;

    void Start()
    {
       GameControllerCar.controllerCar = this;
    }

    public Vector2 GetRectTransformRamdon()
    {
        return RamdomPosition[Random.Range(0, 3)].position;
    }
}
