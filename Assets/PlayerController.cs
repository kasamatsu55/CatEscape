using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //左矢印が押されたとき
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0); //左に「3」動かす
    }

    //右矢印が押されたとき
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0); //右に「3」動かす
    }

    /*
    // Update is called once per frame
    void Update()
    {
        //左矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); //左に「3」動かす
        }

        //右矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); //右に「3」動かす
        }

        //上矢印「UpArrow」、下矢印「DownArrow」、Space「Space」
    }
    */
}
