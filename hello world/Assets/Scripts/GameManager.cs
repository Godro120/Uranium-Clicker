using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI Count;

    [SerializeField] int uranium;

    [SerializeField] float timer = 0;

    private void Update()
    {
        timer = timer + Time.deltaTime;
    }

    //int uranium;

    public void ClickedUranium()
    {
        uranium = uranium + 1;
        Count.text = uranium.ToString();
    }
} 