using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int maxHealth = 5; // Maksimum can sayýsý
    private int currentHealth; // Þu anki can sayýsý

    public Transform startPosition; // Baþlangýç pozisyonu
    public float respawnTime = 2f; // Yeniden doðma süresi

    private bool isDead = false; // Oyuncu öldü mü?

    void Start()
    {
        currentHealth = maxHealth; // Baþlangýçta can sayýsýný ayarla
    }

    void Update()
    {
        if (isDead)
            return;

        // Can durumu UI'da gösterebiliriz, örneðin:
        // UIManager.Instance.UpdateHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Düþmanla çarpýþtýðýnda can kaybý
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

        // Can kaybý sonucu oyuncu ölüyor mu?
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    // Ölme fonksiyonu
    private void Die()
    {
        isDead = true;
        // Öldüðünde baþlangýç noktasýna dön
        Invoke("Respawn", respawnTime);
    }

    // Yeniden doðma iþlemi
    private void Respawn()
    {
        transform.position = startPosition.position; // Baþlangýç noktasýna git
        currentHealth = maxHealth; // Caný doldur
        isDead = false; // Ölü durumu kaldýr
    }
    void GameOver()
    {
        // Burada Game Over ekraný açabilir veya doðrudan sahne yeniden yüklenebilir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Ayný sahneyi yeniden yükler
    }
   

}

