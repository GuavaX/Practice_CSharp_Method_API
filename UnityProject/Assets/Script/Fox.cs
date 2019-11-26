using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0, 50)]
    public float Speed;

    [Header("剛體")]
    public Rigidbody2D Rig;

    [Header("圖片渲染器")]
    public SpriteRenderer Sr;

    public float test;

    /// <summary>
    /// 偵測玩家移動
    /// </summary>
    public void Move()
    {
        float moveSpeed;        
        moveSpeed = Input.GetAxisRaw("Horizontal")*Speed;

        Vector2 a = new Vector2(moveSpeed, 0);
        Rig.AddForce(a, ForceMode2D.Force);
    }

    public void Jump()
    {
        float jump = 0;
        //jump = Input.GetAxisRaw("Vertical") * Speed;
        if (Input.GetKeyDown("space"))
        {
            jump = 2000;
        }        

        Vector2 b = new Vector2(0, jump);
        Rig.AddForce(b, ForceMode2D.Force);
    }

    public void Flip()
    {
        test = Input.GetAxisRaw("Horizontal");
        if (test == -1)
        {
            Sr.flipX = true;
        }
        else if (test == 1)
        {
            Sr.flipX = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Flip();
        Jump();
    }
}
