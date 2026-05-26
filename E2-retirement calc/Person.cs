
//calculates years of work before retirement
namespace Exam2
{
    class Person
    {
        public void YTK()
        {
            YearsToWorkPub = 65 - PubAge;
        }
        private int age = 0;
        private int YearsToWork = 0;
        private string name = "";

        public int PubAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }    
                
                
        }
        public int YearsToWorkPub
        {
            get
            {
                return YearsToWork;
            }
            set
            {
                YearsToWork = value;
            }
        }

        public string PubName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        

          
      



            





    }
}
