// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("odT4a/t9iGj/QKUK85tQv4R2RCTPMi9apnfQdMpIZNrjxLdDRCaAli8UrzAZZp8A9ji2D6JBb8MRbYpf2hmy4gbV4eAUCx3n9AWW0vfBkE5CItx2JRVNE9oXkLKpMlradKTJXGWrIeIQCMVBDI4SG3FmPR6igQyMPqZR7vXhZ/l/aTDwNQZ6TvQIk3Qpvu7sBN8c+/Sv1eZ2vrfVb0BBHC2lVPgPG2CN3cz7ai15MveatwSOqBqZuqiVnpGyHtAeb5WZmZmdmJshMzh5bzWIAlBdowySXWob4qCo6ilkS4Mo8bwiCUmJ8zGL5LEmjjigGpmXmKgamZKaGpmZmAiNMJNTeqNJOLqOWobyIZZh6YTdAA1id64GBXAc7RWSqG6p7ZqbmZiZ");
        private static int[] order = new int[] { 11,13,7,10,10,6,10,10,12,11,11,12,13,13,14 };
        private static int key = 152;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
