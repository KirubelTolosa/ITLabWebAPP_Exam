var url = "https://localhost:44348/api/Credentials";

function loginUser() 
{
   var response;        

	//send request to the API
		var xhttp = new XMLHttpRequest();
		xhttp.onreadystatechange = function() {
			if (this.readyState == 4 && this.status == 200) {										
				response = JSON.parse(xhttp.responseText);
				for (var i=0; i<response.length; i++)
				{		
				   var user = response[i];	
			 	   var userInput = document.getElementById("user");	
				   var passInput = document.getElementById("pass");
					  name.innerText = employee.Name;
		 			  position.innerText = employee.Position;
		 			  var userName = userInput.value;
					  var password = passInput.value;
		   	    	if(userName == user.userName && password == user.password){		   	    		
		   	    		window.open('D:\SelfStudy\ItLabWebApp\index.html');
		   	    		}
		   	    	else{
		   	    		alert("wrong credentials!");
		   	    	}
		   	    							
				}
			};		
		xhttp.open("GET", url, true);
		xhttp.setRequestHeader("Access-Control-Allow-Headers", "*");
		xhttp.send();
	}
}




