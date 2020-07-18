using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanBox : MonoBehaviour
{
    DrawBlock drawBlock;
    void Start() {
        drawBlock = GameObject.FindGameObjectWithTag("Player").GetComponent<DrawBlock>();
    }

    void OnMouseOver() {
        drawBlock.isBoxBanned = true;
    }
}
