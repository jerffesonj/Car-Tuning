using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Material carMaterial;

    private void Start()
    {
        carMaterial = GameObject.FindGameObjectWithTag("CarMesh").GetComponent<MeshRenderer>().material;

        Color carColor = carMaterial.color;

        redSlider.value = carColor.r;
        greenSlider.value = carColor.g;
        blueSlider.value = carColor.b;

        UpdateColor();
    }

    public void UpdateColor()
    {
        // Obtém os valores dos sliders
        float red = redSlider.value;
        float green = greenSlider.value;
        float blue = blueSlider.value;

        // Cria a cor com base nos valores dos sliders
        Color selectedColor = new Color(red, green, blue);

        // Atualiza a cor exibida
        carMaterial.color = selectedColor;
    }
}