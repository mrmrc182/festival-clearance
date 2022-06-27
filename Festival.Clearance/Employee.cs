namespace Festival.Clearance
{
    class Employee 
    {
        public string FirstName;
        public string LastName;
        public int ClearanceLevel;
        public Employee(string firstName, string lastName, int clearanceLevel){
            FirstName=firstName;
            LastName=lastName;
            ClearanceLevel=clearanceLevel;
        }
        public string GetName(){
            return FirstName + " " + LastName;
        }
        public int GetClearanceLevel(){
            return ClearanceLevel;
        }
    }
}