using System;
using TMPro;
using UnityEngine;

public class InvitationMenu : MonoBehaviour
{

    [SerializeField] TMP_InputField ObecnaWaga;
    [SerializeField] TMP_InputField WagaDocelowa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnConfirm()
    {
        float Obecna_Waga = 0f, Waga_Docelowa = 0f;
        try
        {
            Obecna_Waga = Convert.ToSingle(ObecnaWaga.text);
            Waga_Docelowa = Convert.ToSingle(WagaDocelowa.text);
        }
        catch (FormatException e)
        {
            Debug.LogError(e.Message);
            Obecna_Waga = 0f;
            Waga_Docelowa = 0f;
        }



        PlayerPrefs.SetFloat("ObecnaWaga", Obecna_Waga);
        PlayerPrefs.SetFloat("WagaDocelowa", Waga_Docelowa);

        print(PlayerPrefs.GetFloat("ObecnaWaga"));
        print(PlayerPrefs.GetFloat("WagaDocelowa"));
    }
}
