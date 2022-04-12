var list = [];

function postList ()
{
    let id = document.getElementById("id").value;
    let firstname = document.getElementById("firstname").value;
    let lastname = document.getElementById("lastname").value;
    let user = { id, firstname, lastname };
    list.push(user);
    clearInputs();
    if (list.length > 2)
    {
        localStorage.setItem("userList", JSON.stringify(list))
        window.location = "test4.html";
        
    }
    else
    {
        
        alert("Added "+list.length+" user/s");
        
    }
}  
    


function getList ()
{
    let listStr = localStorage.getItem("userList");
    list = JSON.parse(listStr);
    let flag = document.getElementById("number").value;
    let user = list[flag];
    alert(`${user.id} ${user.firstname} ${user.lastname}`);
    
}

function clearInputs()
{
    document.getElementById("id").value = "";
    document.getElementById("firstname").value = "";
    document.getElementById("lastname").value = "";
}