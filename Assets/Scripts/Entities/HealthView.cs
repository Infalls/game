using System;
using System.Collections;
using System.Collections.Generic;
using Entities;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
   [SerializeField] private Slider slider;
   [SerializeField] private Gradient gradient;
   [SerializeField] private Image fill;
   [SerializeField] private Health _health;

   private void OnEnable()
   {
      _health.Damaged += SetHealth;
      _health.HealthChanged += SetMaxHealth;
   }

   private void OnDisable()
   {
      _health.Damaged += SetHealth;
      _health.HealthChanged -= SetMaxHealth;
   }

   private void SetMaxHealth()
   {
      slider.maxValue = _health.MaxHealth;
      slider.value = _health.MaxHealth;
      fill.color = gradient.Evaluate(1f);
   }

   private void SetHealth()
   {
      slider.value = _health.CurrentHealth;
      fill.color = gradient.Evaluate(slider.normalizedValue);
   }
}
