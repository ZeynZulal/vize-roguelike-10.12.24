using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    Animator anim;
    public int currentHealth = 5; // Baþlangýç caný
    public int maxHealth = 5;     // Maksimum can
    public Transform spawnPoint;  // Yeniden doðma noktasý

      // Saðlýk azalmasý ve ölüm kontrolü
        public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Oyuncu öldüðünde yapýlacaklar
    private void Die()
    {
        Debug.Log("Player Died");
        transform.position = spawnPoint.position;  // Yeniden doðma noktasýna git
        currentHealth = maxHealth;  // Caný tekrar maksimuma getir
        // Burada ölüm animasyonu veya efektleri ekleyebiliriz
    }

    
    public void UpdateHealthUI()
    {
        
    }
    public class Player : MonoBehaviour
    {
        Animator anim;

        void Start()
    {
      
    }

        void Update()
    {
           
    }


}
}
