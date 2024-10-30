using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer;
    public GameObject enemyPrefab;
    public FruitManager.Fruit[] fruits;

    private void Start()
    {



    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5)
        {
            timer = 0;
            //instancia un prefab con los datos de fruits[0]

            // Configura las propiedades del prefab antes de instanciarlo
            var enemy = Instantiate(enemyPrefab, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.identity);
            var enemyScript = enemy.GetComponent<EnemyScript>();
            Debug.Log(enemyScript);
            //numero aleatorio para seleccionar una fruta
            int random = Random.Range(0, fruits.Length);

            enemyScript.damage = fruits[random].damage;
            enemyScript.hurtsPlayer = fruits[random].hurtsPlayer;
            enemyScript.isEnchanted = fruits[random].isEnchanted;
            enemyScript.name = fruits[random].name;
            enemyScript.points = fruits[random].points;
            enemyScript.resourcePath = fruits[random].resourcePath;

            //no se renderiza el resource arreglalo porfavor
            enemy.GetComponent<SpriteRenderer>().sprite = fruits[random].sprite;
      

       

        }
    }
}
