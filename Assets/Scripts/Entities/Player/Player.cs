using Entities;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Health Health => _health;
    
    [SerializeField] private Health _health;
    private void Start()
    {
        _health.Init(100);
        _health.Died += OnDie;
    }
    
    private void OnDie()
    {
        Destroy(gameObject);
        _health.Died -= OnDie;
    }
}
