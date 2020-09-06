﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public FloatingJoystick right;
    public FloatingJoystick left;
    float speed=20;
    float rot=5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //左スティックでの縦移動
        this.transform.position += this.transform.forward * right.Vertical * Time.deltaTime;
        //左スティックでの横移動
        this.transform.position += this.transform.right * right.Horizontal * Time.deltaTime; 
        //右スティックでの回転
        transform.Rotate(new Vector3(0,rot*left.Horizontal,0));
    }
}
