using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    public float liveEnemy = 7.0f;
    bool isForward = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        /* IF PRIMER EJEMPLO
        if(transform.position.x < 20f) { 
            MoveEnemy();
        }
        */
        /* IF SEGUNDO EJEMPLO CON ERROR
        if (transform.position.x < 20f)
        {
            MoveEnemy(Vector3.forward);
        }
        else
        {
            MoveEnemy(Vector3.back);
        }
        */
        //IF TERCER EJEMPLO
        if (isForward)
        {
            MoveEnemy(Vector3.forward);
        }
        else
        {
            MoveEnemy(Vector3.back);
        }

        if (transform.position.x < 0f && !isForward)
        {
            isForward = true;
        }

        if (transform.position.x > 20f && isForward)
        {
            isForward = false;
        }

        liveEnemy -= Time.deltaTime;

        if (liveEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
    /*
    private void MoveEnemy()
    {
        transform.Translate(speedEnemy * Time.deltaTime * Vector3.forward);
    }
    */
    //EJEMPLO METODO CON PARÁMETRO
    private void MoveEnemy(Vector3 direction)
    {
        transform.Translate(speedEnemy * Time.deltaTime * direction);
    }
}
