using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider enemyHealthBar;
    public float health = 100f;

    public float _currentHealth;
    private GameObject inter;
    private Interface inter2;

    void Start (){
        _currentHealth = health;
        inter = GameObject.Find("Interface");
        Debug.Log("Start enemy health");
        enemyHealthBar = GameObject.FindObjectOfType<Interface>().getEHB();
        Debug.Log("ehb" + enemyHealthBar);
        //enemyHealthBar = inter2.enemyHB;
        //enemyHealthBar = inter2.gameObject.getEHB();
    }

    void Update(){
        if (_currentHealth <= 0){
            inter.transform.GetChild(2).gameObject.SetActive(true);
            Destroy(gameObject);

        }
    }
    public void TakeDamage(float damage)
    {   
        Debug.Log("Taking damage");
        _currentHealth -= damage;
        enemyHealthBar.value = _currentHealth;
        Debug.Log(_currentHealth);
    }

    public void Recover(float healthPoints)
    {
        if (_currentHealth + healthPoints <= 100){
            _currentHealth += healthPoints;
        }
        enemyHealthBar.value = _currentHealth;
    }
}