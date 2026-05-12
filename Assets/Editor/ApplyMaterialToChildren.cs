using UnityEngine;
using UnityEditor;

public class ApplyMaterialToChildren
{
    [MenuItem("Tools/Apply Material/Belo to Selected Root")]
    static void ApplyBelo()
    {
        // Change this path if your material is elsewhere:
        var mat = AssetDatabase.LoadAssetAtPath<Material>(
            "Assets/OtherAssets/ImportedAssets/Novi objekti/materijali/Belo.mat"
        );

        if (mat == null)
        {
            Debug.LogError("Belo material not found at the given path. Check the path in the script.");
            return;
        }

        var root = Selection.activeGameObject;
        if (root == null)
        {
            Debug.LogError("Select 'Villa Rotonda' in the Hierarchy first.");
            return;
        }

        var renderers = root.GetComponentsInChildren<Renderer>(true);

        Undo.RecordObjects(renderers, "Apply material to children");

        foreach (var r in renderers)
        {
            // Replace ALL material slots (important if meshes have multiple submaterials)
            var mats = r.sharedMaterials;
            for (int i = 0; i < mats.Length; i++)
                mats[i] = mat;

            r.sharedMaterials = mats;
            EditorUtility.SetDirty(r);
        }

        Debug.Log($"Applied {mat.name} to {renderers.Length} renderers under '{root.name}'.");
    }
}