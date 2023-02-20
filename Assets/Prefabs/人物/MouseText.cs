using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseText : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 讀取滑鼠點擊位置
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Input.mousePosition;
            clickPosition.z = Camera.main.transform.position.y - transform.position.y;
            clickPosition = Camera.main.ScreenToWorldPoint(clickPosition);

            // 計算移動方向
            moveDirection = (clickPosition - transform.position).normalized;

            // 轉向角色面向移動方向
            if (moveDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveDirection);
            }
        }
    }
    private void FixedUpdate()
    {
        // 移動角色
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
