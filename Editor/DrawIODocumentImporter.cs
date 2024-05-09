using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace BoysheO.DrawIO
{
    /// <summary>
    /// overrider this class for custom importer or make your self
    /// </summary>
    // ReSharper disable once StringLiteralTypo
    [ScriptedImporter(1, "drawio")]
    public class DrawIODocumentImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            var text = File.ReadAllText(ctx.assetPath);
            var asset = new TextAsset(text);
            ctx.AddObjectToAsset("main obj", asset);
            ctx.SetMainObject(asset);
        }
    }
}