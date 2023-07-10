using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;

    [Header("카메라 최대 / 최소 Y 좌표")]
    public float MaxY = 7;
    public float MinY = 0;

    [Header("카메라 최대 / 최소 X 좌표")]
    public float MaxX = 45;
    public float MinX = 0;

    Vector2 Velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.SmoothDamp(transform.position.x, Target.position.x, ref Velocity.x, 0.3f);
        float y = Mathf.SmoothDamp(transform.position.y, Target.position.y, ref Velocity.y, 0.3f);

        transform.position = new Vector3(Mathf.Clamp(x, 0 , 45), Mathf.Clamp(y, MinY, MaxY), -10);
    }
}
