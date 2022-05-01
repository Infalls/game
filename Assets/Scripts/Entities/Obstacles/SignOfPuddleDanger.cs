using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entities.Obstacles
{
    public class SignOfPuddleDanger : MonoBehaviour
    { 
        [SerializeField] private int forceDeceleration;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out PlayerController playerController))
            {
                playerController._speedMultiplier /= forceDeceleration;
            }
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out PlayerController playerController))
            {
                playerController._speedMultiplier *= forceDeceleration;
            }
        }
    }   
}
