using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider enemyHealthBar;
    public float health = 100f;

    private float _currentHealth;
    private Interface inter;

    void Start (){
        _currentHealth = health;
    }

    void Update(){
        if (_currentHealth <= 0){
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        enemyHealthBar.value = _currentHealth;
    }

    public void Recover(float healthPoints)
    {
        if (_currentHealth + healthPoints <= 100){
            _currentHealth += healthPoints;
        }
        enemyHealthBar.value = _currentHealth;
    }
}