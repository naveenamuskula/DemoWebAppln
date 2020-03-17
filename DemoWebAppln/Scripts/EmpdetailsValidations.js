function Validate() {
    var eno = document.getElementById("txtempno").value;
    var en = document.getElementById("txtename").value;
    var job = document.getElementById("txtjob").value;
    var mgr = document.getElementById("txtmgr").value;
    var hd = document.getElementById("txthiredate").value;
    var sal = document.getElementById("txtsal").value;
    var comm = document.getElementById("txtcomm").value;
   
    var dno = document.getElementById("txtdeptno").value;
    if (eno.length==0 || en.length==0 || job.length==0 || mgr.length==0 || hd.length==0 || sal.length==0 || comm.length==0 || dno.length==0)
    {
        alert("enter all the credentials");
        return false;
    }
    else
        return true;
}