using UnityEngine;

/// <summary>
/// Steuert das Laden / Entladen der Innenleben (Inlays)
/// und stellt eine Methode zum Einfärben der Innenleben bereit
/// </summary>
public class InlayController : MonoBehaviour
{
    /// <summary>
    /// Liste der verfügbaren Innenleben
    /// </summary>
    public GameObject[] inlayPrefabs;

    /// <summary>
    /// Defiert unter welches GameObject das geladene
    /// Innenleben gehängt werden soll
    /// </summary>
    public GameObject anchorTransform;

    /// <summary>
    /// Referenz zu einem geladenen Innenleben
    /// </summary>
    private GameObject currentLoadedInlay;


    private void Start()
    {
        // Set to inital state
        SetInlay(-1);
    }

    /// <summary>
    /// Lädt ein Innenleben aus dem Array für einen übergebenen Index    
    /// </summary>
    /// <param name="index">Welches Innenleben soll geladen werden</param>
    public void SetInlay(int index) 
    {
        if (currentLoadedInlay != null) 
        {
            Destroy(currentLoadedInlay);
            currentLoadedInlay = null;
        }

        // Ist der übergebene Index gültig
        if (index>=0 && index <= inlayPrefabs.Length - 1) 
        {
            // Prefab laden
            GameObject loadedInlay = Instantiate(inlayPrefabs[index]);

            // Geladenes Prefab unter das angegebene GameObject hängen
            loadedInlay.transform.SetParent(anchorTransform.transform, false);

            // Geladenes Innenleben speichern
            currentLoadedInlay = loadedInlay;
        }
    }

}
