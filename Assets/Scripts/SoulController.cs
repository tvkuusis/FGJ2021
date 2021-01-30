using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulController : MonoBehaviour
{
    public float strafeSpeed = 10f;
    public float moveSpeed = 10f;
    public enum MoveDir { Left, Right, None }
    MoveDir _moveDir;

    void Start()
    {
        
    }

    public void Move(bool right)
    {
        if(right)
        {
            _moveDir = MoveDir.Right;
        }
        else
        {
            _moveDir = MoveDir.Left;
        }
    }

    public void StopMove()
    {
        _moveDir = MoveDir.None;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Move(false);
        }
        else if((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            Move(true);
        }
        else
        {
            StopMove();
        }

        transform.Translate(Vector2.up * moveSpeed);

        switch(_moveDir)
        {
            case MoveDir.Left:
                transform.Translate(Vector2.left * strafeSpeed);
                break;
            case MoveDir.Right:
                transform.Translate(Vector2.right * strafeSpeed);
                break;
        }
    }
}
