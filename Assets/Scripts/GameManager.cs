using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    
    public TextMeshProUGUI keyText;
    public int key;
    
    // Start is called before the first frame update
    void Start()
    {
        key = 0;
        UpdateKey(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateKey(int keyNum)
    {
        key += keyNum;
        keyText.text = "Keys: " + key;
    }





}
