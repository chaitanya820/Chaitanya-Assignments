

namespace Assiament_3
{
    class person
    {
        public string firstname;
        public string lastname;
        public string Email_Adress;
        public DateTime Date_of_birth;


        public person(string firstname, string lastname, string email_Adress, DateTime Date_of_birth)

        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Email_Adress = email_Adress;
            this.Date_of_birth = Date_of_birth;
            Console.WriteLine($"{firstname}  {lastname} ,{email_Adress}, {Date_of_birth}");
        }
        public static void Main()
        {
            person p = new person("chaitanya" , "varma", "chaitanyaindukuri19@gmail.com",DateTime.Parse("21/11/1996"));

        }

        
    }
}

    


       
    

