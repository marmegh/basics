namespace carproj {
    public class Vehicle {
        public int numPassengers;
        public double distance;
        public Vehicle(int val = 0){
            numPassengers = val;
            distance = 0.0;
        }
        public void Move(double miles)
        {
            distance += miles;
        }
    }
}