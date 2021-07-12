using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookController : MonoBehaviour
{
    public Image mainImage;
    public GameObject[] capitulos;
    public Sprite[] images;
    public Color colorA0, colorA1;

    private CoroutineController coroutineController;
    private List<int> items;
    // Start is called before the first frame update
    void Start()
    {
        items = new List<int>();
        colorA0 = new Color(0.1960784f,0.1960784f,0.1960784f,0);
        colorA1 = new Color(0.1960784f,0.1960784f,0.1960784f,1);
        for (int i = 0; i < capitulos.Length; i++)
        {
            if (i == 0)
                continue;
            else if (i == 1)
            {
                capitulos[i].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Ir até o choro";
                capitulos[i].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Ignorar o choro";
            }
            else if (i == 3)
            {
                capitulos[i].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(5).gameObject.GetComponentInChildren<Text>().text = "Dar o Biscoito";
                capitulos[i].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Ignorar o Gato";
            }
            else if (i == 5)
            {
                capitulos[i].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(5).gameObject.GetComponentInChildren<Text>().text = "Ir até o som";
                capitulos[i].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Ignorar o som";
            }
            else if (i == 6)
            {
                capitulos[i].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Continuar";
            }
            else if (i == 7)
            {
                capitulos[i].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[i].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Continuar";
            }
            capitulos[i].SetActive(false);
        }
    }


    public void ChangePageButton(string code)
    {
        if (code == "1")
        {
            if (capitulos[0].transform.GetChild(1).gameObject.activeSelf)
            {
                capitulos[0].SetActive(false);
                capitulos[1].SetActive(true);
                mainImage.sprite = images[1];
            }
        }
        else if (code == "2")
        {
            if(capitulos[1].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[1].SetActive(false);
                capitulos[2].SetActive(true);
                mainImage.sprite = images[2];
            }
            else if(capitulos[1].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a ||
            capitulos[1].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                capitulos[1].transform.GetChild(4).GetComponentInChildren<Text>().color = colorA1;
                capitulos[1].transform.GetChild(6).gameObject.SetActive(false);
                capitulos[1].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Proxima";
            }
        }
        else if (code == "2+")
        {
            if(capitulos[1].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                capitulos[1].transform.GetChild(2).GetComponentInChildren<Text>().color = colorA1;
                capitulos[1].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Se Aproximar";
                capitulos[1].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Ignorar";
            }
            else if(capitulos[1].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[1].transform.GetChild(3).GetComponentInChildren<Text>().color = colorA1;
                capitulos[1].transform.GetChild(6).gameObject.SetActive(false);
                capitulos[1].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Continuar";
                items.Add(1);
            }
        }
        else if (code == "3")
        {
            if (capitulos[2].transform.GetChild(1).gameObject.activeSelf)
            {
                capitulos[2].SetActive(false);
                capitulos[3].SetActive(true);
                mainImage.sprite = images[3];
                Debug.Log(items.Count);
            }
        }
        else if (code == "4")
        {
            if(capitulos[3].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[3].SetActive(false);
                capitulos[4].SetActive(true);
                mainImage.sprite = images[4];
            }
            else if(capitulos[3].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                capitulos[3].transform.GetChild(3).GetComponentInChildren<Text>().color = colorA1;
                capitulos[3].transform.GetChild(5).gameObject.SetActive(false);
                capitulos[3].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Proxima";
            }
        }
        else if (code == "4+")
        {
            capitulos[3].transform.GetChild(2).GetComponentInChildren<Text>().color = colorA1;
            capitulos[3].transform.GetChild(5).gameObject.SetActive(false);
            capitulos[3].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Continuar";
            items.Add(1);
        }
        else if (code == "5")
        {
            if (capitulos[4].transform.GetChild(1).gameObject.activeSelf)
            {
                capitulos[4].SetActive(false);
                capitulos[5].SetActive(true);
                mainImage.sprite = images[5];
                Debug.Log(items.Count);
            }
        }
        else if (code == "6")
        {
            if(capitulos[5].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[5].SetActive(false);
                capitulos[6].SetActive(true);
                mainImage.sprite = images[6];
            }
            else if(capitulos[5].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                capitulos[5].transform.GetChild(3).GetComponentInChildren<Text>().color = colorA1;
                capitulos[5].transform.GetChild(5).gameObject.SetActive(false);
                capitulos[5].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Proxima";
            }
        }
        else if (code == "6+")
        {
            capitulos[5].transform.GetChild(1).GetComponentInChildren<Text>().color = colorA0;
            capitulos[5].transform.GetChild(2).GetComponentInChildren<Text>().color = colorA1;
            capitulos[5].transform.GetChild(5).gameObject.SetActive(false);
            capitulos[5].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Continuar";
            items.Add(1);
        }
        else if (code == "7")
        {
            if(capitulos[6].transform.GetChild(1).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[6].transform.GetChild(1).GetComponentInChildren<Text>().color = colorA0;
                capitulos[6].transform.GetChild(2).GetComponentInChildren<Text>().color = colorA1;
                capitulos[6].transform.GetChild(6).GetComponentInChildren<Text>().color = colorA1;
                capitulos[6].transform.GetChild(6).GetComponentInChildren<Text>().text = "Retirar enfeites";
                capitulos[6].transform.GetChild(7).GetComponentInChildren<Text>().text = "Não ajudar o Carvalho";
            }
            else if(capitulos[6].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a ||
            capitulos[6].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color.a == colorA1.a)
            {
                capitulos[6].SetActive(false);
                capitulos[7].SetActive(true);
                mainImage.sprite = images[7];
            }
            else if(capitulos[6].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a ||
            capitulos[6].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                capitulos[6].transform.GetChild(4).GetComponentInChildren<Text>().color = colorA1;
                capitulos[6].transform.GetChild(6).gameObject.SetActive(false);
                capitulos[6].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Proxima";
            }
        }
        else if (code == "7+")
        {
            capitulos[6].transform.GetChild(3).GetComponentInChildren<Text>().color = colorA1;
            capitulos[6].transform.GetChild(6).gameObject.SetActive(false);
            capitulos[6].transform.GetChild(7).gameObject.GetComponentInChildren<Text>().text = "Proxima";
            items.Add(1);
        }
        else if (code == "8")
        {
            if(capitulos[7].transform.GetChild(1).gameObject.GetComponentInChildren<Text>().color.a == colorA0.a)
            {
                Application.Quit();
            }
            else
            {
                capitulos[7].transform.GetChild(1).gameObject.GetComponentInChildren<Text>().color = colorA0;
                capitulos[7].transform.GetChild(6).gameObject.GetComponentInChildren<Text>().text = "Finalizar";
            }

            switch (items.Count)
            {
                case 0:
                    capitulos[7].transform.GetChild(2).gameObject.GetComponentInChildren<Text>().color = colorA1;
                    break;
                case 1:
                case 2:
                case 3:
                    capitulos[7].transform.GetChild(3).gameObject.GetComponentInChildren<Text>().color = colorA1;
                    break;
                case 4:
                    capitulos[7].transform.GetChild(4).gameObject.GetComponentInChildren<Text>().color = colorA1;
                    break;
                default:
                    break;
            }
            
        }
    }




    
}
