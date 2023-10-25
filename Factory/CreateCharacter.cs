using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter : MonoBehaviour
{

    [SerializeField] private UpdateTextCountFarmer _farmerText;
    [SerializeField] private UpdateTextCountWarrior _warriorText;
    
    private UIAnimationReady _UIReadyBarPanel;
    private CreateResources _resources;
    private Timer _timer;


    private int _priceCreateWarrior = 1;
    private int _priceCreateFarmer = 1;

    private int _timeToCreateWarrior = 3;
    public int TimeToCreateWarrior { get { return _timeToCreateWarrior; } }

    private int _timeToCreateFarmer = 3;
    public int TimeToCreateFarmer { get { return _timeToCreateFarmer; } }



    private int _countFarmer = 1;
    public int CountFarmer { get { return _countFarmer; } }

    private int _countWarrior = 1;
    public int CountWarrior { get { return _countWarrior; } }



    void Start()
    {
        _UIReadyBarPanel = GetComponent<UIAnimationReady>();
        _resources = GetComponent<CreateResources>();
        _timer = GetComponent<Timer>();
    }


    public void PressButtonToCreateFarmer()
    {
        if (_resources.WheatCount >= _priceCreateFarmer && _resources.WheatHarvestTime <= 4.5f)
        {
            _UIReadyBarPanel.StartFillingProgressBar();
            _resources.DeleteWheat(_priceCreateFarmer);
            StartCoroutine(TimerToCreateCharacter(_timeToCreateFarmer));
        }
        else
        {
            if(_resources.WheatCount < _priceCreateFarmer)
                Debug.Log("Недостаточно пшеницы");
            else
                Debug.Log("Слишком много фермеров");
        }
    }
    public void PressButtonToCreateWarrior()
    {
        if (_resources.WheatCount < _priceCreateWarrior)
        {
            Debug.Log("Недостаточно пшеницы");
        }
        else
        {
            _resources.DeleteWheat(_priceCreateWarrior);
            StartCoroutine(TimerToCreateCharacter(_timeToCreateWarrior));
        }
    }

    private IEnumerator TimerToCreateCharacter(int timeToCreate)
    {

        Debug.Log($"Корутина выполняеться для {timeToCreate}");
        yield return new WaitForSeconds(timeToCreate);

        if (timeToCreate == _timeToCreateFarmer)
        {
            CreateFarmer();
            Debug.Log("Фермер готов");
        }
        else if (timeToCreate == _timeToCreateWarrior)
        {
            CreateWarrior();
            Debug.Log("Воин готов");
        }
        Debug.Log($"Корутина {timeToCreate} завершилась");
    }

    private void CreateFarmer()
    {
        _countFarmer++;
        _farmerText.UpdateCountFarmer();
        _resources.IncreasedWheatHarvestSpeed(0.5f);
    }
    private void CreateWarrior()
    {
        _countWarrior++;
        _warriorText.UpdateCountWarrior();
    }
}
