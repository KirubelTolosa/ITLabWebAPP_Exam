var url1 = "https://mdmom.org/plot1";
var url2 = "https://mdmom.org/plot2";
/*
function setRef(source){
     var id = source.attributes["id"].nodeValue;
     var display = document.getElementById('svgContainer');
     display.innerHTML = ""; 
     var img = document.createElement("img");
     img.setAttribute('width', 800);
     img.setAttribute('height', 500);
     if(id == "svg1"){
        img.setAttribute("src", url1);
     }
     else {
        img.setAttribute("src", url2);
     } 
     display.append(img); 
}*/

function updateSVG(source)
{    
    var id = source.attributes["id"].nodeValue;
    var timeContainer = document.getElementById("timeContainer");
    var time = document.createElement("li");
    var response; 
    var start_time = new Date().getTime();
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {                                       
                response = xhttp.responseText;
                var display = document.getElementById('svgContainer');                     
                display.innerHTML = "";                     
                display.innerHTML = response;  
                var request_time = new Date().getTime() - start_time;  
                time.append(request_time);
                timeContainer.append(time);
            }
         };               
            xhttp.open("GET",id == "svg1"? url1: url2, true);            
            xhttp.setRequestHeader("Access-Control-Allow-Headers", "*");             
            xhttp.send();                     
}  
       