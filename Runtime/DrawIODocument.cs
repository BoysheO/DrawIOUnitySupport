using System;
using System.Xml.Serialization;
using UnityEngine;

namespace BoysheO.DrawIO
{
    /// <summary>
    /// 建议是在UnityEditor中进一步加工后，存入项目中
    /// </summary>
    public class DrawIODocument
    {
        public mxfile Mxfile { get; private set; }

        public DrawIODocument()
        {
        }

        public void Load(string text)
        {
            try
            {
                using var reader = new System.IO.StringReader(text);
                XmlSerializer xs = new XmlSerializer(typeof(mxfile));
                Mxfile = (mxfile) xs.Deserialize(reader);
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
                Debug.LogError($"DeSerializer DrawIO fail");
            }
        }
    }
}