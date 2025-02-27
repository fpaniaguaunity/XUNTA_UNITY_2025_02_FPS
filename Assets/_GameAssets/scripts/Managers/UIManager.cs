using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider sliderHealth;
    public TextMeshProUGUI textAmmo;
    public TextMeshProUGUI textScore;
    public Image imageBloodVignete;// Viñeta con indicador de salud

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        this.RefreshUI();
    }

    public void RefreshUI()
    {
        sliderHealth.value = gameManager.GetSalud();
        textScore.text = gameManager.GetPuntuacion().ToString();
        // Viñeta con indicador de salud
        Color alfaSalud = new Color(255, 255, 255, 1-(gameManager.GetSalud()/100f));
        imageBloodVignete.color = alfaSalud;
    }
}
