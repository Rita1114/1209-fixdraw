﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    private Animator anim;
    private string[] idleDirections = { "idle-leftdown", "idle-leftup", "idle-rightup", "idle-rightdown" };
   // private string[] WalkDirections = { "walk-leftup", "walk-leftdown", "walk-rightdown", "walk-rightup" };
    
   private string[] WalkDirections = { "walk-leftdown","walk-leftup", "walk-rightup","walk-rightdown"};

    int lastDirection;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();

        float result1 = Vector2.SignedAngle(Vector2.up, Vector2.right);
        Debug.Log("R1" + result1);
        float result2 = Vector2.SignedAngle(Vector2.up, Vector2.left);
        Debug.Log("R2" + result2);
        float result3 = Vector2.SignedAngle(Vector2.up, Vector2.down);
        Debug.Log("R3" + result3);
    }

    public void SetDirection(Vector2 _direction)
    {
        string[] directionArray = null;
        if (anim.GetBool("canwalk") == false)
        {
            directionArray = idleDirections;
        }
        else
        {
            directionArray = WalkDirections;
            lastDirection = DirectionToIndex(_direction);
        }

       // anim.Play(directionArray[lastDirection]);
        
    }

    public void SetAngle(float angle)
    {
        float stepCount = angle / 90;
        int index= Mathf.FloorToInt(stepCount);
        
        string[]    directionArray = WalkDirections;
        
       //第一象限
        if (angle <= 0 && angle > -90)
        {
            index = 0;
        }else if (angle<=-90 && angle >-180) //二
        {
            index = 1;

        }else if (angle <=180&& angle>90)   //三
        {
            index = 2;
        }
        else   //四
        {
            index = 3;
        }
       
        Debug.Log($"{angle} {index}");

        anim.Play(directionArray[index]);
    }

    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 noDir = _direction.normalized;
        float step = 360 / 4;
        float offset = step / 4;

        float angle = Vector2.SignedAngle(Vector2.up, noDir);
       // Debug.Log("angle:"+angle);

        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }

    public void WalkDirection(Vector2 walk_direction)
    {
        if (walk_direction.magnitude > 1)
        {
            anim.SetBool("canwalk", true);
        }
        else
        {
            anim.SetBool("canwalk", false);
        }
        //Debug.Log(walk_direction.magnitude);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}