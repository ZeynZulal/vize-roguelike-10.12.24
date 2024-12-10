using UnityEngine;

public class Enemy : MonoBehaviour//"Enemy" sýnýfý
    //"Enemy" sýnýfýnda "int can, int hasar, saldýr(), hareket()" baþlýklarý bulunur.
{
    public float moveSpeed = 2f;
    public Transform target;
    public int damage = 1;  // Düþmanýn vereceði zarar

    // Oyuncuya çarptýðýnda zarar verme
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) // "Player" tag'ini doðru yazdýðýnýzdan emin ol yoksa kod çalýþmaz!
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
        // Hedefe doðru hareket etme
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
