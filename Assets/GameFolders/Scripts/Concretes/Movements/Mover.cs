using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Enums;

namespace FlyingAlien.Movements
{

    //Bu classı kullanacak olan nesne Rigidbody e sahip olmak zorunda demiş olduk.
    [RequireComponent(typeof(Rigidbody2D))]

    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidbody2D;
        
        private void Awake()
        {

            _rigidbody2D = GetComponent<Rigidbody2D>();

        }

        
        private void OnEnable()
        {

            _rigidbody2D.velocity = SelectNewDirection() * moveSpeed;

        }

        private Vector2 SelectNewDirection()
        {

            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
            {

                selectedDirection = Vector2.left;

            }

            else
            {

                selectedDirection = Vector2.right;

            }

            return selectedDirection;

        }

        

    }

}


