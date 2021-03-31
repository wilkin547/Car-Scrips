using UnityEngine;

public class reScaler : MonoBehaviour
{
    private readonly float[] escalas = { 480, 720, 1080, 1440 };

    public static float ReScaler;

    // Update is called once per frame

    public static Vector2 GetDimisionsInWorldUnits()
    {
        float Width, heigth;
        Camera cam =  Camera.main;
        float radio = (float)cam.pixelWidth / cam.pixelHeight;
        heigth = cam.orthographicSize * 2;
        Width = heigth + radio; 
        return new Vector2(Width, heigth);
    }
    public static Vector2 Unitys()
    {
         switch (Camera.main.pixelWidth)
       {
            
            case 480:
                ReScaler =  0.666666666f;
                break;

            case 720:
                ReScaler = 1;
                break;

            case 1080:
                ReScaler = 1.5f;
                break;

            case 1440:
                ReScaler = 1;
                break;
   
        }
             return new Vector2(ReScaler,ReScaler);
    }
}
