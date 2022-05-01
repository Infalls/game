using System;
using UnityEngine;

namespace Entities
{
     public class Health : MonoBehaviour
     {
          public event Action HealthChanged;
          public event Action Damaged;
          public event Action Died;
          
          public int MaxHealth => _maxHealth;
          public int CurrentHealth => _health;

          private int _maxHealth;

          private int _health;

          public void Init(int maxHealth)
          {
               _maxHealth = _health = maxHealth;
               HealthChanged?.Invoke();
          }
          
          public void GetDamage(int damage)
          {
               _health -= damage;
               
               HealthChanged?.Invoke();
               Damaged?.Invoke();
               
               if (_health <= 0)
                    Died?.Invoke();
          }

          private void ResetHealth()
          {
               _health = _maxHealth;
               HealthChanged?.Invoke();
          }

          private void OnDie()
          {
               Died?.Invoke();
          }

          private void Start()
          {
               ResetHealth();
          }
     }
}
