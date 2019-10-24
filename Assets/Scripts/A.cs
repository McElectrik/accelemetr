using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A : MonoBehaviour
{
    // Move object using accelerometer
    float speed = 5.0f;
    //  Vector3 speed;
    float yrot;
    //float x;
    float y;
  //  float z;

    Vector3 dir = Vector3.zero;
    void Start()

    {
        //экран не будет гаснуть
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
    void Update()
    {
        

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        // dir.x = -Input.acceleration.y;
        //  dir.z = Input.acceleration.x;
        //speed = Input.acceleration;

        // clamp acceleration vector to unit sphere
        //if (dir.sqrMagnitude > 1)
        //    dir.Normalize();

          
      
        // z = Input.acceleration.z;
        dir.y = y - Input.acceleration.y;
       // dir.x = x - Input.acceleration.x;


        // Make it move 10 meters per second instead of 10 meters per frame...
        //  dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
        y = Input.acceleration.y;


        yrot = 1;// Input.acceleration.x  * speed*2;
        // x = Mathf.Round(y);
        //x = y * 10;
        transform.Rotate(0, yrot, 0);


        //void OnGUI()
        // {
        //    GUI.Label(new Rect(Screen.width - 100, 10, 40, 40), _gate.ToString());
        // }

    }
    void OnGUI()
    {
       GUI.Label(new Rect(Screen.width - 500, 10, 200, 200), " y * "+speed+" = " +  y .ToString());

        //GUI.Label(new Rect(Screen.width - 500, 50, 200, 200), " x 100 = " + x.ToString());

        // GUI.Label(new Rect(Screen.width - 500, 90, 200, 200), "Z = " + z.ToString());
    }
}