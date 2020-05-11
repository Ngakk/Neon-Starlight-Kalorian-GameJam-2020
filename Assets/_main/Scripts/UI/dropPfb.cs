using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropPfb : MonoBehaviour
{
    public Image dropImg;
    public TextMeshProUGUI dropName;
    public TextMeshProUGUI dropQty;

    public void SetDropUI(Sprite _spr, string _name, int _qty)
    {
        dropImg.sprite = _spr;
        dropName.text = _name;
        dropQty.text = _qty.ToString();
    }
}
