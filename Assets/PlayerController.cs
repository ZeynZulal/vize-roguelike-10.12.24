using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int maxHealth = 5; // Maksimum can say�s�
    private int currentHealth; // �u anki can say�s�

    public Transform startPosition; // Ba�lang�� pozisyonu
    public float respawnTime = 2f; // Yeniden do�ma s�resi

    private bool isDead = false; // Oyuncu �ld� m�?

    void Start()
    {
        currentHealth = maxHealth; // Ba�lang��ta can say�s�n� ayarla
    }

    void Update()
    {
        if (isDead)
            return;

        // Can durumu UI'da g�sterebiliriz, �rne�in:
        // UIManager.Instance.UpdateHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // D��manla �arp��t���nda can kayb�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isDead)
        {
            TakeDamage(1); // 1 can kaybet
        }
    }

    // Hasar alma fonksiyonu
    private void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Can kayb� sonucu oyuncu �l�yor mu?
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    // �lme fonksiyonu
    private void Die()
    {
        isDead = true;
        // �ld���nde ba�lang�� noktas�na d�n
        Invoke("Respawn", respawnTime);
    }

    // Yeniden do�ma i�lemi
    private void Respawn()
    {
        transform.position = startPosition.position; // Ba�lang�� noktas�na git
        currentHealth = maxHealth; // Can� doldur
        isDead = false; // �l� durumu kald�r
    }
    void GameOver()
    {
        // Burada Game Over ekran� a�abilir veya do�rudan sahne yeniden y�klenebilir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Ayn� sahneyi yeniden y�kler
    }
   

}

