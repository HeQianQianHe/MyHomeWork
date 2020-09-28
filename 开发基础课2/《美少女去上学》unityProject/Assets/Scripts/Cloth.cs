using UnityEngine;
using System.Collections;

    public class Cloth : MonoBehaviour
    {

        public GameObject[] character;
        public int index;
        public Texture btn_tex;
        void Awake()
        {
            foreach (GameObject c in character)
            {
                c.SetActive(false);
            }
            character[0].SetActive(true);
        }


        public void ChangeClothes()
        {
            character[index].SetActive(false);
            index++;
            index %= character.Length;
            character[index].SetActive(true);
        }
}

