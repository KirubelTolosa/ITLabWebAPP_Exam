var url = "https://localhost:44348/api/Employee";
function loadEmployeeList() 
{
   var response;
   var employeeContainer = document.getElementById("list");  
   employeeContainer.innerHTML  = "";        

	//send request to the API
		var xhttp = new XMLHttpRequest();
		xhttp.onreadystatechange = function() {
			if (this.readyState == 4 && this.status == 200) {										
				response = JSON.parse(xhttp.responseText);
				for (var i=0; i<response.length; i++)
				{		
				   var employee = response[i];	
			 	   var employeeDetail = document.createElement("div");
				   var name = document.createElement("h3");
				   var position = document.createElement("h3");
					  name.innerText = employee.Name;
		 			  position.innerText = employee.Position;
		   	    	employeeDetail.append(name);
		  	    	employeeDetail.append(position);			  	    						  	
				  	employeeContainer.append(employeeDetail);		
				}						
			}
			};		
		xhttp.open("GET", url, true);
		xhttp.setRequestHeader("Access-Control-Allow-Headers", "*");
		xhttp.send();
}

function AddEmployee() 
{
	var xhr = new XMLHttpRequest();
	xhr.open("POST", url, true);
	xhr.setRequestHeader('Content-Type', 'application/json');
	xhr.send(JSON.stringify({ "Name": "Genye", "Position": "HR" }));
	loadEmployeeList();
}

