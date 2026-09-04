using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI Count;

    [SerializeField] int uranium;

    //int uranium;

    public void ClickedUranium()
    {
        uranium = uranium + 1;
        Count.text = uranium.ToString();
    }
} 