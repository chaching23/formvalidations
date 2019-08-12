using System.ComponentModel.DataAnnotations;

namespace view.Models
{

public class User
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
}


public class cartoon
{
    [Required(ErrorMessage= "Please enter a first name")]
    [MinLength(3)]
    public string fname {get;set;}
        
    [Required(ErrorMessage= "Please enter a Last name")]
    [MinLength(3)]
    public string lname {get;set;}

    [Required]
    [Range(0,150)]
    public int age {get;set;}

    [Required]
    [EmailAddress]
    public string email {get;set;}

    [Required]
    [DataType(DataType.Password)]

    public string password {get;set;}



    public cartoon(){


    }

    public cartoon(string fname, string lname, int age, string email, string password)
    {
        this.fname=fname;
        this.lname=lname;
        this.age=age;
        this.email=email;
        this.password=password;

    }

}





}