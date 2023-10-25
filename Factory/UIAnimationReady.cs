using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class UIAnimationReady : MonoBehaviour
{
    [SerializeField] private Image _progressBar; // Ссылка на компонент Image прогресс-бара
    public float progressTimer = 3f; // Время заполнения прогресс-бара в секундах

    private float currentProgress = 0f; // Текущий прогресс
    private float targetProgress = 1f; // Целевой прогресс
    private float timer = 0f; // Таймер для отслеживания времени заполнения

    private Coroutine fillCoroutine; // Ссылка на запущенную корутину заполнения

    void Start()
    {
    }

    public void StartFillingProgressBar()
    {
        // Если корутина уже запущена, остановить её
        if (fillCoroutine != null)
            StopCoroutine(fillCoroutine);

        // Сбросить прогресс и таймер
        currentProgress = 0f;
        timer = 0f;

        // Запустить новую корутину
        fillCoroutine = StartCoroutine(FillProgressBarCoroutine());
    }

    private IEnumerator FillProgressBarCoroutine()
    {
        // Цикл будет выполняться до тех пор, пока прогресс не достигнет цели
        while (currentProgress < targetProgress)
        {
            // Увеличиваем прогресс на основе прошедшего времени
            timer += Time.deltaTime;
            currentProgress = Mathf.Lerp(0f, targetProgress, timer / progressTimer);

            // Обновляем fillAmount прогресс-бара
            _progressBar.fillAmount = currentProgress;

            // Ждем один кадр
            yield return null;
        }

        // Прогресс достигнут, сбрасываем корутину
        fillCoroutine = null;
    }





















    //[SerializeField] private UpdateTextCountFarmer _farmer;
    //[SerializeField] private UpdateTextCountWarrior _warrior;

    //private CreateResources _timeToReadyResources;
    //private CreateCharacter _timeToReadyCharacter;

    //private Image _farmerReadyPanel;
    //private Image _warriorReadyPanel;
    //private Image _wheatReadyPanel;


    //void Awake()
    //{

    //}
    //void Start()
    //{
    //    _timeToReadyResources = GetComponent<CreateResources>();
    //    _timeToReadyCharacter = GetComponent<CreateCharacter>();

    //    _wheatReadyPanel = GetComponent<Image>();
    //    _farmerReadyPanel = _farmer.GetComponentInChildren<Image>();
    //    _warriorReadyPanel = _warrior.GetComponentInChildren<Image>();

    //}
    //void Update()
    //{

    //}

    //public void FarmerPanel()
    //{
    //    _farmerReadyPanel.fillAmount += Time.deltaTime / _timeToReadyCharacter.TimeToCreateFarmer;
    //}
    //public void WarriorPanel()
    //{
    //    _warriorReadyPanel.fillAmount += Time.deltaTime / _timeToReadyCharacter.TimeToCreateWarrior;
    //}

    //private void WheatPanel()
    //{
    //    _wheatReadyPanel.fillAmount += Time.deltaTime / _timeToReadyResources.WheatHarvestTime;
    //    if (_wheatReadyPanel.fillAmount >= 1)
    //    {

    //    }
    //}

    //public IEnumerator FillOutReadyPanel()
    //{
    //    bool switcher = true;
    //    while (switcher)
    //    {
    //        yield return new WaitForSeconds(0.2f);

    //    }
    //}




}
