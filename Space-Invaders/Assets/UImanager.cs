using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _shieldsSprites;

    [SerializeField]
    private Image _shieldsImage;

    public void updateShields(int currentShields)
    {
        _shieldsImage.sprite = _shieldsSprites[currentShields];
    }
}
