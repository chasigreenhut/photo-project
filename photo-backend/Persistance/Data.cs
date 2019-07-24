namespace Persistance
{
    public class Data
    {
        private static PhotoEndProjectEntities dB = new PhotoEndProjectEntities();

        public static PhotoEndProjectEntities DB { get { return dB; } }
    }
}
