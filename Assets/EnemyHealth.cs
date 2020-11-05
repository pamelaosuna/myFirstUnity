using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider enemyHealthBar;
    public float health = 100f;

    private float _currentHealth;
    private GameObject inter;

    void Start (){
        _currentHealth = health;
        inter = GameObject.Find("Interface");
    }

    void Update(){
        if (_currentHealth <= 0){
            inter.transform.GetChild(2).gameObject.SetActive(true);
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