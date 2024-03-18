namespace DefaultNamespace
{
    public struct Vector3Data
    {
        public float x, y, z;
    }
    
    public class FakeSensor : System.Object
    {
        public static FakeSensor instance { get; }
        
        public Vector3Data fakeStuff { get; }
        
        public int sampleRate { get; set; }

        public void DoCoolStuff()
        {
            
        }

        public static void OtherCoolStuff()
        {
            
        }
    }
}