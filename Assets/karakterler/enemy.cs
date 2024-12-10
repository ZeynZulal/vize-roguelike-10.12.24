using UnityEngine;

public class Enemy : MonoBehaviour//"Enemy" s�n�f�
    //"Enemy" s�n�f�nda "int can, int hasar, sald�r(), hareket()" ba�l�klar� bulunur.
{
    public float moveSpeed = 2f;
    public Transform target;
    public int damage = 1;  // D��man�n verece�i zarar

    // Oyuncuya �arpt���nda zarar verme
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) // "Player" tag'ini do�ru yazd���n�zdan emin ol yoksa kod �al��maz!
        {
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();//oyuncunun can durumu
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  // Oyuncuya zarar ver
            }
        }
    }

    void Update()
    {
        // Hedefe do�ru hareket etme
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
