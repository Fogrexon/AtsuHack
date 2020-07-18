using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxCounter : MonoBehaviour
{
    public Text text;
    DrawBlock drawBlock;

    void Start() {
        drawBlock = GetComponent<DrawBlock>();
    }

    void Update() {
        text.text = drawBlock.boxCount.ToString() + "Box";
    }
}
