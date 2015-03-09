using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace skbtInstaller
{
    /*  class coreExtensions
     * 
     * Contains helper methods and Custom Types
     */
    public static class skbtCoreExtensions
    {

        // show debug messages (Print serialized objects)
        public static void showDebugMessage(Object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            MessageBox.Show(serializer.Serialize(obj));
        }

        // Extension (<String>)
        public static void showDebugMessage(String Message)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            MessageBox.Show(serializer.Serialize(Message));
        }

        // Extension (<Dictionary>)
        public static void showDebugMessage<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, TValue> serializable = dict.Keys.ToDictionary(p => p.ToString(), p => dict[p]);
            MessageBox.Show(serializer.Serialize(serializable));
        }

        // Extension (<List>)
        public static void showDebugMessage<TValue>(this IList<TValue> list)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            MessageBox.Show(serializer.Serialize(list));
        }
        public static string UCFirst(this String s)
        {
            Char firstLetter = s[0];
            return Char.ToUpper(firstLetter).ToString() + s.Substring(1);
        }

    }

    /*  class KeyValuePairXMLConfigs<TKey, TValue>
     * 
     * Custom KeyValuePair Type so we can XML Serialize
     */
    [XmlType(TypeName = "ServerConfig")]
    public class KeyValuePairXMLConfigs<TKey, TValue>
    {

        public KeyValuePairXMLConfigs()
        {
        }

        public KeyValuePairXMLConfigs(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }

    }

    /*  class KeyValuePairXMLParameters<TKey, TValue>
     * 
     * Custom KeyValuePair Type so we can XML Serialize
     */
    [XmlType(TypeName = "Parameter")]
    public class KeyValuePairXMLParameters<TKey, TValue>
    {

        public KeyValuePairXMLParameters()
        {
        }

        public KeyValuePairXMLParameters(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }

    }

    /// <summary>
    /// Reference Article http://www.codeproject.com/KB/tips/SerializedObjectCloner.aspx
    /// Provides a method for performing a deep copy of an object.
    /// Binary Serialization is used to perform the copy.
    /// </summary>
    public static class ObjectCopier
    {
        /// <summary>
        /// Perform a deep Copy of the object.
        /// </summary>
        /// <typeparam name="T">The type of object being copied.</typeparam>
        /// <param name="source">The object instance to copy.</param>
        /// <returns>The copied object.</returns>
        public static T CloneJson<T>(this T source)
        {
            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));
        }
    }
}
