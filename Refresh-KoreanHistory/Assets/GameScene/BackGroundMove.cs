using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    public Transform Target;

    [Header("배경 최소 / 최대 Y 좌표")]
    float MinY = 0;
    float MaxY = 3;

    Vector2 Velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.SmoothDamp(transform.position.x, Target.position.x, ref Velocity.x, 1f);
        float y = Mathf.SmoothDamp(transform.position.y, Target.position.y, ref Velocity.y, 0.5f);
      
        transform.position = new Vector2(Mathf.Clamp(x, 0, 45), Mathf.Clamp(y, MinY, MaxY));
    }
}
