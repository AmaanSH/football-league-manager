using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    class Data
    {
        // SaveList method will save a list of any type of object, to a filepath specified
        // class of objects in list to be saved must have attribute [Serializable] for this to work
        // method returns false if the data could not be saved due to iunsufficient privileges, invalid filepath etc
        public static bool SaveList<T>(string filepath, List<T> listOfObjects)
        {
            try
            {
                using (Stream stream = File.Open(filepath, FileMode.Create))
                {
                    BinaryFormatter binForm = new BinaryFormatter();
                    binForm.Serialize(stream, listOfObjects);
                }
            }
            catch (Exception ex)
            {
                // show the error message if there is an error
                Console.WriteLine("There was a problem serializing and saving your files: " + ex.ToString());
                return false;
            }

            return true;
        }

        /* LoadList method will return a list of any type of object, from a serialized file at a filepath specified
         class of objects in list to be saved must have attribute [Serializable] for this to work
        the dummy list is necessary for the compiler to recognise the object type T, so it knows what kind of         objects it is working with */
        public static List<T> LoadList<T>(string filepath, List<T> dummy)
        {
            List<T> retList = new List<T>();

            try
            {
                using (Stream stream = File.Open(filepath, FileMode.Open))
                {
                    BinaryFormatter binRead = new BinaryFormatter();
                    retList = (List<T>)binRead.Deserialize(stream);
                    return retList;
                }
            }
            catch (Exception ex)
            {
                // show the error message if there is an error
                Console.WriteLine("There was a problem de-serializing and loading your files: " + ex.ToString());

                // return empty list rather than null, so calling code doesn't have to check for nulls
                return new List<T>();

                // returning null can be a problem for the calling code, which then has to check for nulls
                //return null;
            }

        }
    }
}
