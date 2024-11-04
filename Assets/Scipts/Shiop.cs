using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shiop : MonoBehaviour
{
    [Header("Granny")]
    // Start is called before the first frame update
    public button button;
    public float grannyPrice = 10;
    puiblic int grannyCount = 0;
    private Clicker clicker
    void Start()
    {
        clicker = FindAnyObjectByType<Cliker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyGranny()
    {
        if(clicker.clicks >= grannyPrice)
        {
            clicker.clicks -= Mathf.Ceil
        }
    }
}
