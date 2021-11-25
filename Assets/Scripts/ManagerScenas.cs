using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScenas : MonoBehaviour
{
    [SerializeField]
    private GameObject imagenSelect;
    [SerializeField]
    private List<Sprite> imagens;
    [SerializeField]
    private int position;
    [SerializeField]
    private List<string> nameScenas;

    private void ChangeImagen(){

        imagenSelect.GetComponent<Image>().sprite = imagens[position];
    }
    public void NextImagen()
    {
        if (position<2)
        {
            position++;
            ChangeImagen();
        }

    }
    public void BackImagen()
    {
        if (position>0)
        {
            position--;
            ChangeImagen();
        }
    }
    public void ChangeScena()
    {
        SceneManager.LoadScene(nameScenas[position]);
    }
}
