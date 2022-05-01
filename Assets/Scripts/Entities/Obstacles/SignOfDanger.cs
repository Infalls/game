using UnityEngine;

namespace Entities.Obstacles
{
   public class SignOfDanger : MonoBehaviour
   {
      [SerializeField] private int _damage;
      
      private void OnTriggerEnter2D(Collider2D other)
      {
         if (other.TryGetComponent(out Player player))
            player.Health.GetDamage(_damage);
      }
   }
}
