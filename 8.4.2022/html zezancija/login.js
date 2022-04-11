var attempt = 3; 
function validate()
{

    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    if (username == "123" && password == "123")
    {
        alert ("Login successfull");
        window.location = "test4.html";
        return false;
    }
    else
    {
        attempt --;
        alert("Wrong username or password\nYou have "+attempt+" attempt/s left");
        if (attempt == 0)
        {
            window.location = "test2.html";
            return false;
        }
        
    }
}