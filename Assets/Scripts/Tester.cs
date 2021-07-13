namespace Assembly
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;

    public class Tester : MonoBehaviour
    {
        public float basic;

        /// <summary>
        /// Stuff
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float TestNum { get; set; }
    }
}