using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    Animator anim;
    public int currentHealth = 5; // Ba�lang�� can�
    public int maxHealth = 5;     // Maksimum can
    public Transform spawnPoint;  // Yeniden do�ma noktas�

      // Sa�l�k azalmas� ve �l�m kontrol�
        public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Oyuncu �ld���nde yap�lacaklar
    private void Die()
    {
        Debug.Log("Player Died");
        transform.position = spawnPoint.position;  // Yeniden do�ma noktas�na git
        currentHealth = maxHealth;  // Can� tekrar maksimuma getir
        // Burada �l�m animasyonu veya efektleri ekleyebiliriz
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
