namespace ClassExamples
{
    public class Animal{
        public string color;
        public float weight;
        public float height;
        
        private int respirationRate;

        public int RespirationRate {
            get {
                return respirationRate;
            }
        }

        public void Breathe(){
        }

        public void Move(int speed){

            respirationRate = speed * 5;
            
            //ignore for now how to actually move
        }
    }  
}