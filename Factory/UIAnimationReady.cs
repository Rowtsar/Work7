using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class UIAnimationReady : MonoBehaviour
{
    [SerializeField] private Image _progressBar; // ������ �� ��������� Image ��������-����
    public float progressTimer = 3f; // ����� ���������� ��������-���� � ��������

    private float currentProgress = 0f; // ������� ��������
    private float targetProgress = 1f; // ������� ��������
    private float timer = 0f; // ������ ��� ������������ ������� ����������

    private Coroutine fillCoroutine; // ������ �� ���������� �������� ����������

    void Start()
    {
    }

    public void StartFillingProgressBar()
    {
        // ���� �������� ��� ��������, ���������� �
        if (fillCoroutine != null)
            StopCoroutine(fillCoroutine);

        // �������� �������� � ������
        currentProgress = 0f;
        timer = 0f;

        // ��������� ����� ��������
        fillCoroutine = StartCoroutine(FillProgressBarCoroutine());
    }

    private IEnumerator FillProgressBarCoroutine()
    {
        // ���� ����� ����������� �� ��� ���, ���� �������� �� ��������� ����
        while (currentProgress < targetProgress)
        {
            // ����������� �������� �� ������ ���������� �������
            timer += Time.deltaTime;
            currentProgress = Mathf.Lerp(0f, targetProgress, timer / progressTimer);

            // ��������� fillAmount ��������-����
            _progressBar.fillAmount = currentProgress;

            // ���� ���� ����
            yield return null;
        }

        // �������� ���������, ���������� ��������
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
