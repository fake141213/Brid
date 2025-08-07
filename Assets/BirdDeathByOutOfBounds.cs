using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdDeathByOutOfBounds : MonoBehaviour
{
    public float lowerBound = -6;
    public float upperBound = 6;
    private bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (!isDead)
         {
            if (transform.position.y < lowerBound || transform.position.y > upperBound)
            {
                isDead = true;
                LogicScript logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
                logic.GameOver();
            }
         }
        
    }
}
