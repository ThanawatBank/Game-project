using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private PlayerController playerData;
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        text.text = playerData.GetKey().ToString();
    }
}
