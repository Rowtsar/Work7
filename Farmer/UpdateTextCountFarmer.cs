using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextCountFarmer : MonoBehaviour
{
    [SerializeField] private CreateCharacter _countCharactrer;
    [SerializeField] private Text _textCountFarmer;

    void Start()
    {
        _textCountFarmer.text = _countCharactrer.CountFarmer.ToString();
    }



    public void UpdateCountFarmer()
    {
        _textCountFarmer.text = _countCharactrer.CountFarmer.ToString();
    }
}
