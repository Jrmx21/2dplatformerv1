using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    [System.Serializable]
    public class Fruit
    {
        public string name;
        public int points;
        public bool hurtsPlayer;
        public int damage;
        public bool isEnchanted;
        public string resourcePath;
        public Sprite sprite; // Cambia el recurso de tipo Sprite

        public Fruit(string name, int points, bool hurtsPlayer, int damage, bool isEnchanted, string resourcePath)
        {
            this.name = name;
            this.points = points;
            this.hurtsPlayer = hurtsPlayer;
            this.damage = damage;
            this.isEnchanted = isEnchanted;
            this.resourcePath = resourcePath;
        }
    }
    
    private void Start()
    {
        //cookie que está en el resources path llamado Food siendo un splice de la imagen Food, siendo la galleta Food_0



    }




}
