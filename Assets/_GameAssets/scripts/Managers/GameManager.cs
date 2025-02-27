using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int puntuacion;
    [SerializeField]
    private int salud;

    UIManager uiManager;
    void Start()
    {
        this.uiManager = GameObject.Find("GameManager").GetComponent<UIManager>();
    }
    void Update()
    {
        
    }
    public void agregarPuntuacion(int puntacion)
    {
        this.puntuacion += puntuacion;
        this.uiManager.RefreshUI();
    }
    public void agregarSalud(int salud)
    {
        this.salud += salud;
        this.uiManager.RefreshUI();
    }
    public void decrementarSalud(int salud)
    {
        this.salud -= salud;
        this.uiManager.RefreshUI();
    }
    public int GetSalud()
    {
        return this.salud;
    }
    public int GetPuntuacion()
    {
        return this.puntuacion;
    }
}