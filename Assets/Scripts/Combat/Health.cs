using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat

{

        public class Health : MonoBehaviour
        {
          [SerializeField]int health = 100;

          public void TakeDamage(int damage)
          {
            health = Mathf.Max(health - damage,0);
            print(health);
          }
        }

}