using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GuardarNombre : MonoBehaviour
{
    public InputField inputField;
    public void Guardar()
    {
        string textoAGuardar = inputField.text;
        string rutaArchivo = Application.dataPath + "/usuarios.txt";

        try
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine(textoAGuardar);
            }

            Debug.Log("Se ha guardado el texto '" + textoAGuardar + "' en el archivo '" + rutaArchivo + "'");
        }
        catch (IOException e)
        {
            Debug.LogError("Error al guardar el archivo: " + e.Message);
        }
    }
}

