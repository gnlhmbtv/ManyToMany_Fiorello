let btnAdd=document.getElementById("btnAdd");
let input=document.getElementById("input");
let list=document.getElementById("list");
let btnRemove=document.getElementById("btnRemove");
let fas=document.getElementById("fas");

btnAdd.addEventListener("click",function(){
    let value=input.value.trim();
    if(value==""){
        alert("Do not leave empty");
        return;
    };
    let li=document.createElement("li");
    let i=document.createElement("i");
    i.onclick=function(){
        li.remove();
    }
    i.classList.add("fas");
    i.classList.add("fa-trash-alt");
    i.setAttribute("id","fas");

    li.classList.add("list-group-item");
    li.classList.add("test");
    li.innerText=value;
    list.appendChild(li);
    li.appendChild(i);
    input.value=""; 

});

btnRemove.addEventListener("click",function(){
   
        list.innerHTML="";
        list.firstChild.remove();
    });