using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int currentAmount = 0;


    [SerializeField] //ļauj iekš editor redzēt un piekļūt private mainīgajam
    private int maxAmount = 1;
    public static Counter instance;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount >= maxAmount)
        {
           // EndScreen.SetActive(true);
           // Player.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            currentAmount = 0;
        }
    }
}
