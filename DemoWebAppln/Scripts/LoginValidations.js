function Validate()
{
    var un = document.getElementById("txtusername").value;
    var pwd = document.getElementById("txtpassword").value;
    if (un.length == 0 || pwd.length == 0)
    {
        alert("enter Username/Password");
        return false;
    }
    else
        return true;
}