namespace AllInOne.Common.Library.Object
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    using log4net;

    /// <summary>
    /// Convenience class for performing object-related functions.
    /// </summary>
    public sealed class ObjectUtil
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (ObjectUtil));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Function to get byte array from a instance.
        /// </summary>
        /// <param name="instance">Object to get byte array.</param>
        /// <returns>Byte Array or null in the event that conversion failed.</returns>
        public static byte[] ConvertToByteArray(object instance)
        {
            //Perform a first level check that the instance is serializable
            //However, this does not guarantee that it does not itself make reference to
            //other complex objects
            if (!instance.GetType().IsSerializable)
            {
                Logger.WarnFormat("Instance {0} cannot be converted to byte array because it is not serializable!",
                    instance);
                return null;
            }

            try
            {
                // create new memory stream
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // create new BinaryFormatter
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    // Serializes an instance, or graph of connected objects, to the given stream.
                    binaryFormatter.Serialize(memoryStream, instance);

                    // convert stream to byte array and return
                    return memoryStream.ToArray();
                }
            }
            catch (Exception exception)
            {
                //One of the scenarios that an exception is encountered is the fields, containing complex objects,
                //are themseleves not serializable
                Logger.Error(String.Format("Error encountered during conversion of instance {0} to byte array", instance), exception);
            }

            // Error occured, return null
            return null;
        }

        /// <summary>
        /// Converts to object.
        /// </summary>
        /// <param name="instanceArray">The instance array.</param>
        /// <returns></returns>
        public static object ConvertToObject(byte[] instanceArray)
        {
            //Perform a first level check that the instance is deserializable
            if (instanceArray == null || instanceArray.LongLength == 0)
            {
                Logger.Warn("Instance array is either null or empty...unable to convert/deserialize!");
                return null;
            }

            try
            {
                // create new memory stream
                using (MemoryStream memoryStream = new MemoryStream(instanceArray))
                {
                    // create new BinaryFormatter
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    // Deserializes the stream into an object instance.
                    return binaryFormatter.Deserialize(memoryStream);
                }
            }
            catch (Exception exception)
            {
                Logger.Error("Error encountered during deseriaization of byte array", exception);
            }

            // Error occured, return null
            return null;
        }

        #endregion Methods
    }
}